namespace LinqPractice.Questions;

public static class AnyQuestions
{
    // Write your LINQ answers below.
    // ANY-01 — Is work waiting?
    // Inspect `orders` and return true as soon as at least one order has the status "Pending".
    // Return false for an empty list or when no pending order exists.
    public static bool HasPendingOrders(IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // ANY-02 — Customers with order history
    // From `customers`, keep customers for whom at least one matching order exists in `orders`.
    // Match Customer.Id to Order.CustomerId, return customer names, and sort alphabetically.
    public static IReadOnlyList<string> CustomersWithOrders(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // ANY-03 — Products never ordered
    // Find products for which no order item has a matching ProductId. Return the product names
    // alphabetically. This is the LINQ equivalent of a SQL NOT EXISTS query.
    public static IReadOnlyList<string> ProductsNeverOrdered(
        IEnumerable<Product> products,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // ANY-04 — Departments with a high earner
    // Return department names when at least one employee in that department earns strictly
    // more than `minimumSalary`. Match Department.Id to Employee.DeptId and sort by department.
    public static IReadOnlyList<string> DepartmentsWithHighEarner(
        IEnumerable<Department> departments,
        IEnumerable<Employee> employees,
        decimal minimumSalary) =>
        throw new NotImplementedException();
}
