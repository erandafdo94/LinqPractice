namespace LinqPractice.Answers;

public static class JoinAnswers
{
    public static IReadOnlyList<(string Employee, string Department)> EmployeeDepartments(
        IEnumerable<Employee> employees, IEnumerable<Department> departments) =>
        (from e in employees join d in departments on e.DeptId equals d.Id orderby e.Name select (e.Name, d.Name)).ToList();

    public static IReadOnlyList<string> CustomersWhoOrdered(
        IEnumerable<Customer> customers, IEnumerable<Order> orders, IEnumerable<OrderItem> items,
        IEnumerable<Product> products, string productName) =>
        (from c in customers join o in orders on c.Id equals o.CustomerId join i in items on o.Id equals i.OrderId
         join p in products on i.ProductId equals p.Id where p.Name == productName select c.Name)
        .Distinct().OrderBy(name => name).ToList();

    public static IReadOnlyList<(int OrderId, string Customer, string Product, decimal LineTotal)> ShippedInvoiceLines(
        IEnumerable<Order> orders, IEnumerable<Customer> customers, IEnumerable<OrderItem> items, IEnumerable<Product> products) =>
        (from o in orders where o.Status == "Shipped" join c in customers on o.CustomerId equals c.Id
         join i in items on o.Id equals i.OrderId join p in products on i.ProductId equals p.Id
         orderby o.Id, p.Name select (o.Id, c.Name, p.Name, i.Quantity * i.UnitPrice)).ToList();

    public static IReadOnlyList<(int OrderId, string Customer)> OrdersWithCustomerNames(
        IEnumerable<Order> orders, IEnumerable<Customer> customers) =>
        (from o in orders join c in customers on o.CustomerId equals c.Id orderby o.Id select (o.Id, c.Name)).ToList();

    public static IReadOnlyList<(int OrderItemId, string Product, int Quantity, decimal UnitPrice)> OrderItemProductDetails(
        IEnumerable<OrderItem> items, IEnumerable<Product> products) =>
        (from i in items join p in products on i.ProductId equals p.Id orderby i.Id
         select (i.Id, p.Name, i.Quantity, i.UnitPrice)).ToList();

    public static IReadOnlyList<(string Employee, string Manager)> EmployeeManagerPairs(IEnumerable<Employee> employees) =>
        (from e in employees join m in employees on e.ManagerId equals m.Id orderby e.Name select (e.Name, m.Name)).ToList();

    public static IReadOnlyList<(string Customer, int OrderId, DateOnly OrderDate)> CustomerOrderDates(
        IEnumerable<Customer> customers, IEnumerable<Order> orders) =>
        (from c in customers join o in orders on c.Id equals o.CustomerId orderby c.Name, o.OrderDate, o.Id
         select (c.Name, o.Id, o.OrderDate)).ToList();

    public static IReadOnlyList<(string Product, int Quantity)> ProductQuantityLines(
        IEnumerable<Product> products, IEnumerable<OrderItem> items) =>
        (from i in items join p in products on i.ProductId equals p.Id orderby p.Name, i.Id select (p.Name, i.Quantity)).ToList();

    public static IReadOnlyList<(string Department, string Employee, decimal Salary)> DepartmentSalaryRoster(
        IEnumerable<Department> departments, IEnumerable<Employee> employees) =>
        (from d in departments join e in employees on d.Id equals e.DeptId orderby d.Name, e.Name
         select (d.Name, e.Name, e.Salary)).ToList();

    public static IReadOnlyList<(int OrderId, string Customer, decimal Total)> ShippedOrderCustomerTotals(
        IEnumerable<Order> orders, IEnumerable<Customer> customers, IEnumerable<OrderItem> items) =>
        (from o in orders where o.Status == "Shipped" join c in customers on o.CustomerId equals c.Id
         join i in items on o.Id equals i.OrderId group i by new { o.Id, c.Name } into g orderby g.Key.Id
         select (g.Key.Id, g.Key.Name, g.Sum(i => i.Quantity * i.UnitPrice))).ToList();
}
