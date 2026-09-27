namespace LinqPractice.Answers;

public static class OrderingAnswers
{
    public static IReadOnlyList<string> CustomersByCityThenName(IEnumerable<Customer> customers) =>
        customers.OrderBy(c => c.City).ThenBy(c => c.Name).Select(c => c.Name).ToList();

    public static IReadOnlyList<string> ProductsMostExpensiveFirst(IEnumerable<Product> products) =>
        products.OrderByDescending(p => p.UnitPrice).ThenBy(p => p.Name).Select(p => p.Name).ToList();

    public static IReadOnlyList<string> EmployeesBySalaryThenName(IEnumerable<Employee> employees) =>
        employees.OrderByDescending(e => e.Salary).ThenBy(e => e.Name).Select(e => e.Name).ToList();

    public static IReadOnlyList<int> OrdersNewestFirst(IEnumerable<Order> orders) =>
        orders.OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.Id).Select(o => o.Id).ToList();

    public static IReadOnlyList<string> DepartmentsByNameLength(IEnumerable<Department> departments) =>
        departments.OrderBy(d => d.Name.Length).ThenBy(d => d.Name).Select(d => d.Name).ToList();

    public static IReadOnlyList<string> CustomersNewestSignupFirst(IEnumerable<Customer> customers) =>
        customers.OrderByDescending(c => c.SignupDate).ThenBy(c => c.Name).Select(c => c.Name).ToList();

    public static IReadOnlyList<int> OrderItemsByQuantityThenPrice(IEnumerable<OrderItem> orderItems) =>
        orderItems.OrderByDescending(i => i.Quantity).ThenByDescending(i => i.UnitPrice)
            .ThenBy(i => i.Id).Select(i => i.Id).ToList();

    public static IReadOnlyList<string> ProductsByCategoryThenPrice(IEnumerable<Product> products) =>
        products.OrderBy(p => p.Category).ThenBy(p => p.UnitPrice).ThenBy(p => p.Name)
            .Select(p => p.Name).ToList();

    public static IReadOnlyList<string> ManagersBeforeReports(IEnumerable<Employee> employees) =>
        employees.OrderBy(e => e.ManagerId is null ? 0 : 1).ThenByDescending(e => e.Salary)
            .ThenBy(e => e.Name).Select(e => e.Name).ToList();

    public static IReadOnlyList<int> OrdersByStatusThenDate(IEnumerable<Order> orders) =>
        orders.OrderBy(o => o.Status).ThenBy(o => o.OrderDate).ThenBy(o => o.Id).Select(o => o.Id).ToList();
}
