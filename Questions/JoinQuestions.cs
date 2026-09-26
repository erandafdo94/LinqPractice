namespace LinqPractice.Questions;

public static class JoinQuestions
{
    // Write your LINQ answers below.
    // JOIN-01 — Employee directory with assigned departments
    // Inner-join employees to departments using Employee.DeptId and Department.Id. Return
    // (Employee, Department) tuples ordered by employee name. Omit unassigned employees.
    public static IReadOnlyList<(string Employee, string Department)> EmployeeDepartments(
        IEnumerable<Employee> employees,
        IEnumerable<Department> departments) =>
        throw new NotImplementedException();

    // JOIN-02 — Who ordered this product?
    // Join customers, orders, order items, and products to find customers who bought the exact
    // `productName`. Return distinct customer names alphabetically.
    public static IReadOnlyList<string> CustomersWhoOrdered(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems,
        IEnumerable<Product> products,
        string productName) =>
        throw new NotImplementedException();

    // JOIN-03 — Create shipped invoice lines
    // For shipped orders, join all four related inputs and return OrderId, Customer, Product,
    // and Quantity × the captured OrderItem.UnitPrice. Sort by OrderId and then product name.
    public static IReadOnlyList<(int OrderId, string Customer, string Product, decimal LineTotal)> ShippedInvoiceLines(
        IEnumerable<Order> orders,
        IEnumerable<Customer> customers,
        IEnumerable<OrderItem> orderItems,
        IEnumerable<Product> products) =>
        throw new NotImplementedException();
}
