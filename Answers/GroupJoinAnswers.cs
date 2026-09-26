namespace LinqPractice.Answers;

public static class GroupJoinAnswers
{
    public static IReadOnlyList<(string Customer, int OrderCount)> OrderCountByCustomer() =>
        PracticeData.Customers
            .GroupJoin(
                PracticeData.Orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, orders) => (customer.Name, orders.Count()))
            .OrderBy(row => row.Name)
            .ToList();

    public static IReadOnlyList<(string Employee, string Department)> EmployeeDepartmentDirectory() =>
        (from employee in PracticeData.Employees
         join department in PracticeData.Departments on employee.DeptId equals department.Id into departments
         from department in departments.DefaultIfEmpty()
         orderby employee.Name
         select (employee.Name, department?.Name ?? "Unassigned"))
        .ToList();

    public static IReadOnlyList<(string Department, int EmployeeCount, decimal TotalSalary)> DepartmentPayrollSummary() =>
        PracticeData.Departments
            .GroupJoin(
                PracticeData.Employees,
                department => department.Id,
                employee => employee.DeptId,
                (department, employees) =>
                    (department.Name, employees.Count(), employees.Sum(employee => employee.Salary)))
            .OrderBy(row => row.Name)
            .ToList();

    public static IReadOnlyList<(string Employee, int DirectReports)> DirectReportCountByEmployee() =>
        PracticeData.Employees
            .GroupJoin(
                PracticeData.Employees,
                manager => manager.Id,
                employee => employee.ManagerId,
                (manager, reports) => (manager.Name, reports.Count()))
            .OrderBy(row => row.Name)
            .ToList();
}
