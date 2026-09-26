namespace LinqPractice.Answers;

public static class JoinAnswers
{
    public static IReadOnlyList<(string Employee, string Department)> EmployeeDepartments() =>
        (from employee in PracticeData.Employees
         join department in PracticeData.Departments on employee.DeptId equals department.Id
         orderby employee.Name
         select (employee.Name, department.Name))
        .ToList();

    public static IReadOnlyList<string> CustomersWhoOrdered(string productName) =>
        (from customer in PracticeData.Customers
         join order in PracticeData.Orders on customer.Id equals order.CustomerId
         join item in PracticeData.OrderItems on order.Id equals item.OrderId
         join product in PracticeData.Products on item.ProductId equals product.Id
         where product.Name == productName
         select customer.Name)
        .Distinct()
        .OrderBy(name => name)
        .ToList();

    public static IReadOnlyList<(int OrderId, string Customer, string Product, decimal LineTotal)> ShippedInvoiceLines() =>
        (from order in PracticeData.Orders
         where order.Status == "Shipped"
         join customer in PracticeData.Customers on order.CustomerId equals customer.Id
         join item in PracticeData.OrderItems on order.Id equals item.OrderId
         join product in PracticeData.Products on item.ProductId equals product.Id
         orderby order.Id, product.Name
         select (order.Id, customer.Name, product.Name, item.Quantity * item.UnitPrice))
        .ToList();
}
