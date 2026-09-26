namespace LinqPractice.Answers;

public static class AllAnswers
{
    public static bool AreAllOrdersFinalized() =>
        PracticeData.Orders.All(order => order.Status is "Shipped" or "Cancelled");

    public static IReadOnlyList<string> DepartmentsWhereEveryoneEarnsAtLeast(decimal minimumSalary) =>
        PracticeData.Departments
            .Where(department =>
            {
                var employees = PracticeData.Employees.Where(employee => employee.DeptId == department.Id);
                return employees.Any() && employees.All(employee => employee.Salary >= minimumSalary);
            })
            .OrderBy(department => department.Name)
            .Select(department => department.Name)
            .ToList();

    public static IReadOnlyList<string> CustomersWithOnlyShippedOrders() =>
        PracticeData.Customers
            .Where(customer =>
            {
                var orders = PracticeData.Orders.Where(order => order.CustomerId == customer.Id);
                return orders.Any() && orders.All(order => order.Status == "Shipped");
            })
            .OrderBy(customer => customer.Name)
            .Select(customer => customer.Name)
            .ToList();
}
