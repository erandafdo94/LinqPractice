namespace LinqPractice.Answers;

public static class GroupJoinAnswers
{
    public static IReadOnlyList<(string Customer, int OrderCount)> OrderCountByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders) =>
        customers.GroupJoin(orders, c => c.Id, o => o.CustomerId, (c, os) => (c.Name, os.Count()))
            .OrderBy(x => x.Name).ToList();

    public static IReadOnlyList<(string Employee, string Department)> EmployeeDepartmentDirectory(
        IEnumerable<Employee> employees, IEnumerable<Department> departments) =>
        (from e in employees join d in departments on e.DeptId equals d.Id into ds from d in ds.DefaultIfEmpty()
         orderby e.Name select (e.Name, d?.Name ?? "Unassigned")).ToList();

    public static IReadOnlyList<(string Department, int EmployeeCount, decimal TotalSalary)> DepartmentPayrollSummary(
        IEnumerable<Department> departments, IEnumerable<Employee> employees) =>
        departments.GroupJoin(employees, d => d.Id, e => e.DeptId,
                (d, es) => (d.Name, es.Count(), es.Sum(e => e.Salary))).OrderBy(x => x.Name).ToList();

    public static IReadOnlyList<(string Employee, int DirectReports)> DirectReportCountByEmployee(IEnumerable<Employee> employees)
    {
        var list = employees.ToList();
        return list.GroupJoin(list, m => m.Id, e => e.ManagerId, (m, rs) => (m.Name, rs.Count()))
            .OrderBy(x => x.Name).ToList();
    }

    public static IReadOnlyList<(string Product, int ItemCount)> OrderItemCountByProduct(
        IEnumerable<Product> products, IEnumerable<OrderItem> items) =>
        products.GroupJoin(items, p => p.Id, i => i.ProductId, (p, its) => (p.Name, its.Count()))
            .OrderBy(x => x.Name).ToList();

    public static IReadOnlyList<(string Customer, int? LatestOrderId)> LatestOrderIdByCustomer(
        IEnumerable<Customer> customers, IEnumerable<Order> orders) =>
        customers.GroupJoin(orders, c => c.Id, o => o.CustomerId, (c, os) =>
                (c.Name, (int?)os.OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.Id).FirstOrDefault()?.Id))
            .OrderBy(x => x.Name).ToList();

    public static IReadOnlyList<(string Department, decimal HighestSalary)> HighestSalaryByDepartment(
        IEnumerable<Department> departments, IEnumerable<Employee> employees) =>
        departments.GroupJoin(employees, d => d.Id, e => e.DeptId,
                (d, es) => (d.Name, es.Select(e => e.Salary).DefaultIfEmpty(0m).Max()))
            .OrderBy(x => x.Name).ToList();

    public static IReadOnlyList<(int OrderId, int ItemCount)> ItemCountByOrder(
        IEnumerable<Order> orders, IEnumerable<OrderItem> items) =>
        orders.GroupJoin(items, o => o.Id, i => i.OrderId, (o, its) => (o.Id, its.Count()))
            .OrderBy(x => x.Id).ToList();

    public static IReadOnlyList<(string Product, int TotalQuantity)> TotalQuantityByProduct(
        IEnumerable<Product> products, IEnumerable<OrderItem> items) =>
        products.GroupJoin(items, p => p.Id, i => i.ProductId, (p, its) => (p.Name, its.Sum(i => i.Quantity)))
            .OrderBy(x => x.Name).ToList();

    public static IReadOnlyList<(string Employee, string Reports)> DirectReportNamesByEmployee(IEnumerable<Employee> employees)
    {
        var list = employees.ToList();
        return list.GroupJoin(list, m => m.Id, e => e.ManagerId,
                (m, rs) => (m.Name, string.Join(", ", rs.OrderBy(e => e.Name).Select(e => e.Name))))
            .OrderBy(x => x.Name).ToList();
    }
}
