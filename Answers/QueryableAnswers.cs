namespace LinqPractice.Answers;

public static class QueryableAnswers
{
    public static IQueryable<Order> ShippedOrdersFrom(IQueryable<Order> orders, DateOnly fromDate) =>
        orders
            .Where(order => order.Status == "Shipped" && order.OrderDate >= fromDate)
            .OrderBy(order => order.OrderDate)
            .ThenBy(order => order.Id);

    public static IQueryable<Order> OrdersForCustomer(IQueryable<Order> orders, int customerId) =>
        orders
            .Where(order => order.CustomerId == customerId)
            .OrderByDescending(order => order.OrderDate)
            .ThenByDescending(order => order.Id);

    public static IQueryable<Order> OrderPage(
        IQueryable<Order> orders,
        int pageIndex,
        int pageSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(pageIndex);
        ArgumentOutOfRangeException.ThrowIfLessThan(pageSize, 1);

        return orders
            .OrderBy(order => order.OrderDate)
            .ThenBy(order => order.Id)
            .Skip(pageIndex * pageSize)
            .Take(pageSize);
    }
}
