namespace LinqPractice.Questions;

public static class AggregateQuestions
{
    // Write your LINQ answers below.
    // AGG-01 — Calculate every order total
    // Difficulty: Simple
    // For each order, find its order items and sum Quantity × UnitPrice. Return (OrderId, Total)
    // for every order, ordered by OrderId. An order without items should have a total of zero.
    public static IReadOnlyList<(int OrderId, decimal Total)> OrderTotals(
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-02 — Largest order per customer
    // Difficulty: Simple
    // Calculate each order's total, then return the largest total for every customer who has
    // placed an order. Omit customers with no orders and sort the result by customer name.
    public static IReadOnlyList<(string Customer, decimal Total)> LargestOrderByCustomer(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-03 — Average order value
    // Difficulty: Simple
    // Calculate the total of every supplied order and return the average of those totals.
    // Return 0m when `orders` is empty instead of allowing Average to throw.
    public static decimal AverageOrderValue(IEnumerable<Order> orders, IEnumerable<OrderItem> items) =>
        throw new NotImplementedException();

    // AGG-04 — Running shipped revenue
    // Difficulty: Medium
    // Order shipped orders chronologically by OrderDate and ID. After each order, add its item
    // total to a running balance and emit (OrderId, CumulativeRevenue).
    public static IReadOnlyList<(int OrderId, decimal CumulativeRevenue)> RunningShippedRevenue(
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-05 — Revenue across all order lines
    // Difficulty: Medium
    // Sum Quantity × UnitPrice across every order item and return the decimal total. An empty input
    // should produce zero.
    public static decimal TotalOrderItemRevenue(IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-06 — Average catalogue price
    // Difficulty: Medium
    // Return the average UnitPrice across products. Return 0m for an empty product sequence rather
    // than allowing Average to throw.
    public static decimal AverageProductPrice(IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // AGG-07 — Highest employee salary
    // Difficulty: Medium
    // Return the maximum Salary, or 0m if there are no employees.
    public static decimal HighestEmployeeSalary(IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // AGG-08 — Smallest order total
    // Difficulty: Hard
    // Calculate totals for all orders and return the smallest. Orders without items count as zero;
    // return 0m when no orders exist.
    public static decimal LowestOrderTotal(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-09 — Total units by product
    // Difficulty: Hard
    // Return ProductId and summed Quantity for every ProductId appearing in order items. Sort by
    // ProductId; no Product input is required.
    public static IReadOnlyList<(int ProductId, int Units)> TotalUnitsByProduct(
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // AGG-10 — Orders above the overall average
    // Difficulty: Hard
    // Calculate every order total and the average of those totals, then return IDs whose total is
    // strictly above the average. Sort IDs ascending; return none when there are no orders.
    public static IReadOnlyList<int> OrdersAboveOverallAverage(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();
}
