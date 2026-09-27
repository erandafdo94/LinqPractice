namespace LinqPractice.Answers;

public static class AggregateAnswers
{
    private static decimal Total(Order order, IReadOnlyList<OrderItem> items) =>
        items.Where(i => i.OrderId == order.Id).Sum(i => i.Quantity * i.UnitPrice);

    public static IReadOnlyList<(int OrderId, decimal Total)> OrderTotals(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        return orders.OrderBy(o => o.Id).Select(o => (o.Id, Total(o, items))).ToList();
    }

    public static IReadOnlyList<(string Customer, decimal Total)> LargestOrderByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var os = orders.ToList(); var items = orderItems.ToList();
        return customers.Where(c => os.Any(o => o.CustomerId == c.Id)).OrderBy(c => c.Name)
            .Select(c => (c.Name, os.Where(o => o.CustomerId == c.Id).Max(o => Total(o, items)))).ToList();
    }

    public static decimal AverageOrderValue(IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        return orders.Select(o => Total(o, items)).DefaultIfEmpty(0m).Average();
    }

    public static IReadOnlyList<(int OrderId, decimal CumulativeRevenue)> RunningShippedRevenue(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList(); decimal running = 0m;
        return orders.Where(o => o.Status == "Shipped").OrderBy(o => o.OrderDate).ThenBy(o => o.Id)
            .Select(o => (o.Id, CumulativeRevenue: running += Total(o, items))).ToList();
    }

    public static decimal TotalOrderItemRevenue(IEnumerable<OrderItem> orderItems) =>
        orderItems.Sum(i => i.Quantity * i.UnitPrice);

    public static decimal AverageProductPrice(IEnumerable<Product> products) =>
        products.Select(p => p.UnitPrice).DefaultIfEmpty(0m).Average();

    public static decimal HighestEmployeeSalary(IEnumerable<Employee> employees) =>
        employees.Select(e => e.Salary).DefaultIfEmpty(0m).Max();

    public static decimal LowestOrderTotal(IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        return orders.Select(o => Total(o, items)).DefaultIfEmpty(0m).Min();
    }

    public static IReadOnlyList<(int ProductId, int Units)> TotalUnitsByProduct(IEnumerable<OrderItem> orderItems) =>
        orderItems.GroupBy(i => i.ProductId).OrderBy(g => g.Key).Select(g => (g.Key, g.Sum(i => i.Quantity))).ToList();

    public static IReadOnlyList<int> OrdersAboveOverallAverage(IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        var totals = orders.Select(o => (o.Id, Total: Total(o, items))).ToList();
        if (totals.Count == 0) return [];
        var average = totals.Average(x => x.Total);
        return totals.Where(x => x.Total > average).OrderBy(x => x.Id).Select(x => x.Id).ToList();
    }
}
