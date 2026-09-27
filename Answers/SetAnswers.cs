namespace LinqPractice.Answers;

public static class SetAnswers
{
    private static IEnumerable<string> CustomersWhoOrdered(
        IEnumerable<Customer> customers, IEnumerable<Order> orders, IEnumerable<OrderItem> items,
        IEnumerable<Product> products, string productName) =>
        from c in customers join o in orders on c.Id equals o.CustomerId
        join i in items on o.Id equals i.OrderId join p in products on i.ProductId equals p.Id
        where p.Name == productName select c.Name;

    public static IReadOnlyList<string> DistinctCustomerCitiesWithOrders(IEnumerable<Customer> customers, IEnumerable<Order> orders) =>
        (from c in customers join o in orders on c.Id equals o.CustomerId select c.City)
        .Distinct().OrderBy(city => city).ToList();

    public static IReadOnlyList<string> CustomersNeedingFollowUp(IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var list = orders.ToList();
        var pending = customers.Where(c => list.Any(o => o.CustomerId == c.Id && o.Status == "Pending")).Select(c => c.Name);
        var cancelled = customers.Where(c => list.Any(o => o.CustomerId == c.Id && o.Status == "Cancelled")).Select(c => c.Name);
        return pending.Union(cancelled).OrderBy(name => name).ToList();
    }

    public static IReadOnlyList<string> CustomersWhoOrderedMonitorAndMouse(
        IEnumerable<Customer> customers, IEnumerable<Order> orders, IEnumerable<OrderItem> items, IEnumerable<Product> products)
    {
        var cs = customers.ToList(); var os = orders.ToList(); var its = items.ToList(); var ps = products.ToList();
        return CustomersWhoOrdered(cs, os, its, ps, "Monitor").Intersect(CustomersWhoOrdered(cs, os, its, ps, "Mouse"))
            .OrderBy(name => name).ToList();
    }

    public static IReadOnlyList<string> ProductsNeverShipped(
        IEnumerable<Product> products, IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var shippedIds = from o in orders where o.Status == "Shipped"
                         join i in orderItems on o.Id equals i.OrderId select i.ProductId;
        return products.ExceptBy(shippedIds, p => p.Id).OrderBy(p => p.Name).Select(p => p.Name).ToList();
    }

    public static IReadOnlyList<string> CustomerAndEmployeeNames(IEnumerable<Customer> customers, IEnumerable<Employee> employees) =>
        customers.Select(c => c.Name).Concat(employees.Select(e => e.Name)).ToList();

    public static IReadOnlyList<string> FirstCustomerNameByCity(IEnumerable<Customer> customers) =>
        customers.OrderBy(c => c.Name).DistinctBy(c => c.City).OrderBy(c => c.City).Select(c => c.Name).ToList();

    public static IReadOnlyList<string> UniqueCustomerAndEmployeeNames(IEnumerable<Customer> customers, IEnumerable<Employee> employees) =>
        customers.Select(c => c.Name).Union(employees.Select(e => e.Name)).OrderBy(name => name).ToList();

    public static IReadOnlyList<string> CustomersWithoutOrders(IEnumerable<Customer> customers, IEnumerable<Order> orders) =>
        customers.ExceptBy(orders.Select(o => o.CustomerId), c => c.Id).OrderBy(c => c.Name).Select(c => c.Name).ToList();

    public static IReadOnlyList<string> CustomersWithShippedAndPendingOrders(IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var list = orders.ToList();
        var ids = list.Where(o => o.Status == "Shipped").Select(o => o.CustomerId)
            .Intersect(list.Where(o => o.Status == "Pending").Select(o => o.CustomerId));
        return customers.Where(c => ids.Contains(c.Id)).OrderBy(c => c.Name).Select(c => c.Name).ToList();
    }

    public static IReadOnlyList<string> ProductsOrderedInYearButNotAnother(
        IEnumerable<Product> products, IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems,
        int includedYear, int excludedYear)
    {
        var os = orders.ToList(); var items = orderItems.ToList();
        var included = os.Where(o => o.OrderDate.Year == includedYear)
            .SelectMany(o => items.Where(i => i.OrderId == o.Id)).Select(i => i.ProductId);
        var excluded = os.Where(o => o.OrderDate.Year == excludedYear)
            .SelectMany(o => items.Where(i => i.OrderId == o.Id)).Select(i => i.ProductId);
        var ids = included.Except(excluded).ToHashSet();
        return products.Where(p => ids.Contains(p.Id)).OrderBy(p => p.Name).Select(p => p.Name).ToList();
    }
}
