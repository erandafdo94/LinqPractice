namespace LinqPractice.Answers;

public static class ToDictionaryAnswers
{
    public static IReadOnlyDictionary<int, string> ProductNamesById(IEnumerable<Product> products) =>
        products.ToDictionary(p => p.Id, p => p.Name);

    public static IReadOnlyDictionary<string, string> LatestOrderStatusByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var os = orders.ToList();
        return customers.Where(c => os.Any(o => o.CustomerId == c.Id)).ToDictionary(c => c.Name,
            c => os.Where(o => o.CustomerId == c.Id).OrderByDescending(o => o.OrderDate)
                .ThenByDescending(o => o.Id).First().Status);
    }

    public static IReadOnlyDictionary<string, int> EmployeeCountByDepartment(
        IEnumerable<Department> departments, IEnumerable<Employee> employees)
    {
        var es = employees.ToList();
        return departments.ToDictionary(d => d.Name, d => es.Count(e => e.DeptId == d.Id));
    }

    public static IReadOnlyDictionary<int, decimal> OrderTotalsById(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        return orders.ToDictionary(o => o.Id,
            o => items.Where(i => i.OrderId == o.Id).Sum(i => i.Quantity * i.UnitPrice));
    }

    public static IReadOnlyDictionary<int, string> CustomerCitiesById(IEnumerable<Customer> customers) =>
        customers.ToDictionary(c => c.Id, c => c.City);

    public static IReadOnlyDictionary<string, decimal> DepartmentPayrollByName(
        IEnumerable<Department> departments, IEnumerable<Employee> employees)
    {
        var es = employees.ToList();
        return departments.ToDictionary(d => d.Name,
            d => es.Where(e => e.DeptId == d.Id).Sum(e => e.Salary));
    }

    public static IReadOnlyDictionary<string, int> LatestOrderIdByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var os = orders.ToList();
        return customers.Where(c => os.Any(o => o.CustomerId == c.Id)).ToDictionary(c => c.Name,
            c => os.Where(o => o.CustomerId == c.Id).OrderByDescending(o => o.OrderDate)
                .ThenByDescending(o => o.Id).First().Id);
    }

    public static IReadOnlyDictionary<string, decimal> ProductPricesByName(IEnumerable<Product> products) =>
        products.ToDictionary(p => p.Name, p => p.UnitPrice);

    public static IReadOnlyDictionary<string, decimal> ShippedRevenueByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var os = orders.ToList(); var items = orderItems.ToList();
        return customers.ToDictionary(c => c.Name,
            c => os.Where(o => o.CustomerId == c.Id && o.Status == "Shipped")
                .SelectMany(o => items.Where(i => i.OrderId == o.Id)).Sum(i => i.Quantity * i.UnitPrice));
    }

    public static IReadOnlyDictionary<string, int> OrderCountByStatus(IEnumerable<Order> orders) =>
        orders.GroupBy(o => o.Status).ToDictionary(g => g.Key, g => g.Count(), StringComparer.Ordinal);
}
