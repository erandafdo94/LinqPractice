namespace LinqPractice.Answers;

public static class SelectManyAnswers
{
    public static IReadOnlyList<(int OrderId, int ProductId, int Quantity)> AllOrderLines() =>
        PracticeData.Orders
            .SelectMany(
                order => PracticeData.OrderItems.Where(item => item.OrderId == order.Id),
                (order, item) => new { order.Id, Item = item })
            .OrderBy(row => row.Id)
            .ThenBy(row => row.Item.Id)
            .Select(row => (row.Id, row.Item.ProductId, row.Item.Quantity))
            .ToList();

    public static IReadOnlyList<(string Customer, string Products)> ProductsByCustomer() =>
        PracticeData.Customers
            .OrderBy(customer => customer.Name)
            .Select(customer =>
            {
                var names = PracticeData.Orders
                    .Where(order => order.CustomerId == customer.Id)
                    .SelectMany(order => PracticeData.OrderItems.Where(item => item.OrderId == order.Id))
                    .Join(PracticeData.Products, item => item.ProductId, product => product.Id,
                        (_, product) => product.Name)
                    .Distinct()
                    .OrderBy(name => name);
                return (customer.Name, string.Join(", ", names));
            })
            .ToList();

    public static IReadOnlyList<(string Department, string Employee)> DepartmentEmployees() =>
        PracticeData.Departments
            .SelectMany(
                department => PracticeData.Employees.Where(employee => employee.DeptId == department.Id),
                (department, employee) => (Department: department.Name, Employee: employee.Name))
            .OrderBy(row => row.Department)
            .ThenBy(row => row.Employee)
            .ToList();

    public static IReadOnlyList<(string Customer, decimal Revenue)> ShippedRevenueByCustomer() =>
        PracticeData.Customers
            .OrderBy(customer => customer.Name)
            .Select(customer =>
            {
                var revenue = PracticeData.Orders
                    .Where(order => order.CustomerId == customer.Id && order.Status == "Shipped")
                    .SelectMany(order => PracticeData.OrderItems.Where(item => item.OrderId == order.Id))
                    .Sum(item => item.Quantity * item.UnitPrice);
                return (customer.Name, revenue);
            })
            .ToList();
}
