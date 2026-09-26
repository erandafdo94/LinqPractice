namespace LinqPractice.Questions;

public static class SelectManyQuestions
{
    // Write your LINQ answers below.
    // MANY-01 — Flatten orders into their lines
    // For each order, find its matching order items and flatten them into one result sequence.
    // Return (OrderId, ProductId, Quantity), ordered by OrderId and then OrderItem.Id.
    public static IReadOnlyList<(int OrderId, int ProductId, int Quantity)> AllOrderLines(
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // MANY-02 — Products purchased by each customer
    // For every customer, walk through their orders and order items to find product names.
    // Remove duplicate names, sort them alphabetically, and join them with ", ". Customers
    // with no orders must still appear with an empty string.
    public static IReadOnlyList<(string Customer, string Products)> ProductsByCustomer(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems,
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // MANY-03 — Flatten departments and employees
    // Match each department to its employees and return (Department, Employee) pairs. Empty
    // departments produce no rows. Sort by department name and then employee name.
    public static IReadOnlyList<(string Department, string Employee)> DepartmentEmployees(
        IEnumerable<Department> departments,
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // MANY-04 — Shipped revenue per customer
    // For every customer, flatten their shipped orders into order items and sum Quantity ×
    // UnitPrice. Include customers with no shipped revenue as zero and sort by customer name.
    public static IReadOnlyList<(string Customer, decimal Revenue)> ShippedRevenueByCustomer(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();
}
