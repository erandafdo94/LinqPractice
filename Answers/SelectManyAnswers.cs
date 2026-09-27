namespace LinqPractice.Answers;

public static class SelectManyAnswers
{
    public static IReadOnlyList<(int OrderId, int ProductId, int Quantity)> AllOrderLines(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        return orders.SelectMany(o => items.Where(i => i.OrderId == o.Id), (o, i) => new { o.Id, Item = i })
            .OrderBy(x => x.Id).ThenBy(x => x.Item.Id).Select(x => (x.Id, x.Item.ProductId, x.Item.Quantity)).ToList();
    }

    public static IReadOnlyList<(string Customer, string Products)> ProductsByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems, IEnumerable<Product> products)
    {
        var orderList = orders.ToList(); var items = orderItems.ToList(); var productList = products.ToList();
        return customers.OrderBy(c => c.Name).Select(c =>
        {
            var names = orderList.Where(o => o.CustomerId == c.Id)
                .SelectMany(o => items.Where(i => i.OrderId == o.Id))
                .Join(productList, i => i.ProductId, p => p.Id, (_, p) => p.Name).Distinct().OrderBy(n => n);
            return (c.Name, string.Join(", ", names));
        }).ToList();
    }

    public static IReadOnlyList<(string Department, string Employee)> DepartmentEmployees(
        IEnumerable<Department> departments, IEnumerable<Employee> employees)
    {
        var list = employees.ToList();
        return departments.SelectMany(d => list.Where(e => e.DeptId == d.Id),
                (d, e) => (Department: d.Name, Employee: e.Name))
            .OrderBy(x => x.Department).ThenBy(x => x.Employee).ToList();
    }

    public static IReadOnlyList<(string Customer, decimal Revenue)> ShippedRevenueByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var orderList = orders.ToList(); var items = orderItems.ToList();
        return customers.OrderBy(c => c.Name).Select(c =>
            (c.Name, orderList.Where(o => o.CustomerId == c.Id && o.Status == "Shipped")
                .SelectMany(o => items.Where(i => i.OrderId == o.Id)).Sum(i => i.Quantity * i.UnitPrice))).ToList();
    }

    public static IReadOnlyList<(int OrderId, string Product, int Quantity)> OrderLinesWithProducts(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems, IEnumerable<Product> products)
    {
        var items = orderItems.ToList();
        return orders.SelectMany(o => items.Where(i => i.OrderId == o.Id), (o, i) => new { o.Id, Item = i })
            .Join(products, x => x.Item.ProductId, p => p.Id, (x, p) => (x.Id, p.Name, x.Item.Quantity))
            .OrderBy(x => x.Id).ThenBy(x => x.Name).ToList();
    }

    public static IReadOnlyList<(string Manager, string Report)> ManagerReportPairs(IEnumerable<Employee> employees)
    {
        var list = employees.ToList();
        return list.SelectMany(m => list.Where(e => e.ManagerId == m.Id),
                (m, e) => (Manager: m.Name, Report: e.Name))
            .OrderBy(x => x.Manager).ThenBy(x => x.Report).ToList();
    }

    public static IReadOnlyList<(string Customer, int OrderId)> CustomerOrderIds(
        IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var list = orders.ToList();
        return customers.SelectMany(c => list.Where(o => o.CustomerId == c.Id), (c, o) => (c.Name, o.Id))
            .OrderBy(x => x.Name).ThenBy(x => x.Id).ToList();
    }

    public static IReadOnlyList<(string Category, string Product)> CategoryProductPairs(IEnumerable<Product> products) =>
        products.GroupBy(p => p.Category).SelectMany(g => g, (g, p) => (g.Key, p.Name))
            .OrderBy(x => x.Key).ThenBy(x => x.Name).ToList();

    public static IReadOnlyList<(int OrderId, decimal LineTotal)> OrderLineRevenue(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        return orders.SelectMany(o => items.Where(i => i.OrderId == o.Id), (o, i) => new { o.Id, Item = i })
            .OrderBy(x => x.Id).ThenBy(x => x.Item.Id).Select(x => (x.Id, x.Item.Quantity * x.Item.UnitPrice)).ToList();
    }

    public static IReadOnlyList<string> ProductNamesOrderedWithStatus(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems, IEnumerable<Product> products, string status)
    {
        var items = orderItems.ToList();
        return orders.Where(o => o.Status == status).SelectMany(o => items.Where(i => i.OrderId == o.Id))
            .Join(products, i => i.ProductId, p => p.Id, (_, p) => p.Name)
            .Distinct().OrderBy(name => name).ToList();
    }
}
