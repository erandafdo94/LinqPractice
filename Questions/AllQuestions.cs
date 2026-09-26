namespace LinqPractice.Questions;

public static class AllQuestions
{
    // Write your LINQ answers below.
    // ALL-01 — Are all orders finalized?
    // An order is final when its status is either "Shipped" or "Cancelled". Return true only
    // when every supplied order is final. Remember that All returns true for an empty sequence.
    public static bool AreAllOrdersFinalized(IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // ALL-02 — Departments meeting a salary floor
    // Return departments that have at least one employee and where every employee earns at
    // least `minimumSalary`. Empty departments must not qualify. Sort names alphabetically.
    public static IReadOnlyList<string> DepartmentsWhereEveryoneEarnsAtLeast(
        IEnumerable<Department> departments,
        IEnumerable<Employee> employees,
        decimal minimumSalary) =>
        throw new NotImplementedException();

    // ALL-03 — Customers whose orders all shipped
    // Return customers who placed at least one order and whose matching orders are all marked
    // "Shipped". Customers with no orders must not qualify. Return names alphabetically.
    public static IReadOnlyList<string> CustomersWithOnlyShippedOrders(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();
}
