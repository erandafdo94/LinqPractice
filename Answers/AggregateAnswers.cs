namespace LinqPractice.Answers;

public static class AggregateAnswers
{
    public static IReadOnlyList<(int OrderId, decimal Total)> OrderTotals() =>
        PracticeData.Orders
            .OrderBy(order => order.Id)
            .Select(order =>
                (order.Id, PracticeData.OrderItems
                    .Where(item => item.OrderId == order.Id)
                    .Sum(item => item.Quantity * item.UnitPrice)))
            .ToList();

    public static IReadOnlyList<(string Customer, decimal Total)> LargestOrderByCustomer() =>
        PracticeData.Customers
            .Where(customer => PracticeData.Orders.Any(order => order.CustomerId == customer.Id))
            .OrderBy(customer => customer.Name)
            .Select(customer =>
            {
                var largest = PracticeData.Orders
                    .Where(order => order.CustomerId == customer.Id)
                    .Max(order => PracticeData.OrderItems
                        .Where(item => item.OrderId == order.Id)
                        .Sum(item => item.Quantity * item.UnitPrice));
                return (customer.Name, largest);
            })
            .ToList();

    public static decimal AverageOrderValue(IEnumerable<Order> orders, IEnumerable<OrderItem> items)
    {
        var itemList = items.ToList();
        return orders
            .Select(order => itemList
                .Where(item => item.OrderId == order.Id)
                .Sum(item => item.Quantity * item.UnitPrice))
            .DefaultIfEmpty(0m)
            .Average();
    }

    public static IReadOnlyList<(int OrderId, decimal CumulativeRevenue)> RunningShippedRevenue() =>
        PracticeData.Orders
            .Where(order => order.Status == "Shipped")
            .OrderBy(order => order.OrderDate)
            .ThenBy(order => order.Id)
            .Aggregate(
                new RunningTotalState(0m, []),
                (state, order) =>
                {
                    var orderTotal = PracticeData.OrderItems
                        .Where(item => item.OrderId == order.Id)
                        .Sum(item => item.Quantity * item.UnitPrice);
                    var nextTotal = state.Total + orderTotal;
                    state.Rows.Add((order.Id, nextTotal));
                    return state with { Total = nextTotal };
                })
            .Rows;

    private sealed record RunningTotalState(
        decimal Total,
        List<(int OrderId, decimal CumulativeRevenue)> Rows);
}
