namespace LinqPractice.Answers;

public static class ToDictionaryAnswers
{
    public static IReadOnlyDictionary<int, string> ProductNamesById() =>
        PracticeData.Products
            .ToDictionary(product => product.Id, product => product.Name);

    public static IReadOnlyDictionary<string, string> LatestOrderStatusByCustomer() =>
        PracticeData.Orders
            .Join(
                PracticeData.Customers,
                order => order.CustomerId,
                customer => customer.Id,
                (order, customer) => new { Customer = customer.Name, Order = order })
            .GroupBy(row => row.Customer)
            .ToDictionary(
                group => group.Key,
                group => group
                    .OrderByDescending(row => row.Order.OrderDate)
                    .ThenByDescending(row => row.Order.Id)
                    .First().Order.Status);

    public static IReadOnlyDictionary<string, int> EmployeeCountByDepartment() =>
        PracticeData.Departments
            .ToDictionary(
                department => department.Name,
                department => PracticeData.Employees.Count(employee => employee.DeptId == department.Id));

    public static IReadOnlyDictionary<int, decimal> OrderTotalsById() =>
        PracticeData.Orders
            .ToDictionary(
                order => order.Id,
                order => PracticeData.OrderItems
                    .Where(item => item.OrderId == order.Id)
                    .Sum(item => item.Quantity * item.UnitPrice));
}
