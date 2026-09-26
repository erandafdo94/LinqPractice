namespace LinqPractice.Questions;

public static class AggregateQuestions
{
    // Write your LINQ answers below.
    // AGG-01 — Calculate every order total
    // For each order, find its order items and sum Quantity × UnitPrice. Return (OrderId, Total)
    // for every order, ordered by OrderId. An order without items should have a total of zero.
    public static IReadOnlyList<(int OrderId, decimal Total)> OrderTotals(
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-02 — Largest order per customer
    // Calculate each order's total, then return the largest total for every customer who has
    // placed an order. Omit customers with no orders and sort the result by customer name.
    public static IReadOnlyList<(string Customer, decimal Total)> LargestOrderByCustomer(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-03 — Average order value
    // Calculate the total of every supplied order and return the average of those totals.
    // Return 0m when `orders` is empty instead of allowing Average to throw.
    public static decimal AverageOrderValue(IEnumerable<Order> orders, IEnumerable<OrderItem> items) =>
        throw new NotImplementedException();

    // AGG-04 — Running shipped revenue
    // Order shipped orders chronologically by OrderDate and ID. After each order, add its item
    // total to a running balance and emit (OrderId, CumulativeRevenue).
    public static IReadOnlyList<(int OrderId, decimal CumulativeRevenue)> RunningShippedRevenue(
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();
}
