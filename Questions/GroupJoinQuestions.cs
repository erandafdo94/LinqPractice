namespace LinqPractice.Questions;

public static class GroupJoinQuestions
{
    // Write your LINQ answers below.
    // GJOIN-01 — Order count for every customer
    // Group-join customers to orders and return (Customer, OrderCount). Keep customers who have
    // no orders with a count of zero, and sort the rows by customer name.
    public static IReadOnlyList<(string Customer, int OrderCount)> OrderCountByCustomer(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // GJOIN-02 — Employee directory with missing departments
    // Perform a left outer join from employees to departments. Return every employee and use
    // "Unassigned" when DeptId is null or has no match. Sort by employee name.
    public static IReadOnlyList<(string Employee, string Department)> EmployeeDepartmentDirectory(
        IEnumerable<Employee> employees,
        IEnumerable<Department> departments) =>
        throw new NotImplementedException();

    // GJOIN-03 — Department payroll report
    // Group-join every department to its employees. Return department name, employee count,
    // and total salary. Empty departments must appear with zero headcount and zero payroll.
    public static IReadOnlyList<(string Department, int EmployeeCount, decimal TotalSalary)> DepartmentPayrollSummary(
        IEnumerable<Department> departments,
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // GJOIN-04 — Direct-report counts
    // Treat the employee input as both managers and reports. Match Manager.Id to Employee.ManagerId
    // and return every employee with their direct-report count, including zero, sorted by name.
    public static IReadOnlyList<(string Employee, int DirectReports)> DirectReportCountByEmployee(
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();
}
