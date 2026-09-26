namespace LinqPractice.Answers;

public static class OrderingAnswers
{
    public static IReadOnlyList<string> CustomersByCityThenName() =>
        PracticeData.Customers
            .OrderBy(customer => customer.City)
            .ThenBy(customer => customer.Name)
            .Select(customer => customer.Name)
            .ToList();

    public static IReadOnlyList<string> ProductsMostExpensiveFirst() =>
        PracticeData.Products
            .OrderByDescending(product => product.UnitPrice)
            .ThenBy(product => product.Name)
            .Select(product => product.Name)
            .ToList();

    public static IReadOnlyList<string> EmployeesBySalaryThenName() =>
        PracticeData.Employees
            .OrderByDescending(employee => employee.Salary)
            .ThenBy(employee => employee.Name)
            .Select(employee => employee.Name)
            .ToList();
}
