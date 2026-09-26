namespace LinqPractice.Answers;

public static class AnyAnswers
{
    public static bool HasPendingOrders() =>
        PracticeData.Orders.Any(order => order.Status == "Pending");

    public static IReadOnlyList<string> CustomersWithOrders() =>
        PracticeData.Customers
            .Where(customer => PracticeData.Orders.Any(order => order.CustomerId == customer.Id))
            .OrderBy(customer => customer.Name)
            .Select(customer => customer.Name)
            .ToList();

    public static IReadOnlyList<string> ProductsNeverOrdered() =>
        PracticeData.Products
            .Where(product => !PracticeData.OrderItems.Any(item => item.ProductId == product.Id))
            .OrderBy(product => product.Name)
            .Select(product => product.Name)
            .ToList();

    public static IReadOnlyList<string> DepartmentsWithHighEarner(decimal minimumSalary) =>
        PracticeData.Departments
            .Where(department => PracticeData.Employees.Any(employee =>
                employee.DeptId == department.Id && employee.Salary > minimumSalary))
            .OrderBy(department => department.Name)
            .Select(department => department.Name)
            .ToList();
}
