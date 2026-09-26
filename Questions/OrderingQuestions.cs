namespace LinqPractice.Questions;

public static class OrderingQuestions
{
    // Write your LINQ answers below.
    // ORDER-01 — Sort a customer directory
    // Return customer names grouped naturally by location: sort customers by City first and
    // then by Name within each city. The result should contain names only.
    public static IReadOnlyList<string> CustomersByCityThenName(IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // ORDER-02 — Most expensive products first
    // Return product names ordered from highest UnitPrice to lowest. If prices are equal,
    // sort those products alphabetically so the result is deterministic.
    public static IReadOnlyList<string> ProductsMostExpensiveFirst(IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // ORDER-03 — Salary ranking
    // Rank employees from highest salary to lowest and return their names. Employees with the
    // same salary must be ordered alphabetically; do not return the salary itself.
    public static IReadOnlyList<string> EmployeesBySalaryThenName(IEnumerable<Employee> employees) =>
        throw new NotImplementedException();
}
