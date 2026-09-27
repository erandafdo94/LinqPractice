namespace LinqPractice.Answers;

public static class ElementAnswers
{
    public static Order? FirstShippedOrder(IEnumerable<Order> orders) =>
        orders.Where(o => o.Status == "Shipped").OrderBy(o => o.OrderDate).ThenBy(o => o.Id).FirstOrDefault();

    public static Product? ProductByExactName(IEnumerable<Product> products, string name) =>
        products.SingleOrDefault(p => p.Name == name);

    public static Order? LatestOrderOrDefault(IEnumerable<Order> orders, int customerId) =>
        orders.Where(o => o.CustomerId == customerId).OrderByDescending(o => o.OrderDate)
            .ThenByDescending(o => o.Id).FirstOrDefault();

    public static Product? CheapestProduct(IEnumerable<Product> products) => products.MinBy(p => p.UnitPrice);

    public static Customer? FirstCustomerInCity(IEnumerable<Customer> customers, string city) =>
        customers.Where(c => c.City == city).OrderBy(c => c.Name).FirstOrDefault();

    public static Department? DepartmentByExactName(IEnumerable<Department> departments, string name) =>
        departments.SingleOrDefault(d => d.Name == name);

    public static Product? MostExpensiveProduct(IEnumerable<Product> products) =>
        products.OrderBy(p => p.Name).MaxBy(p => p.UnitPrice);

    public static Order? LastOrderInYear(IEnumerable<Order> orders, int year) =>
        orders.Where(o => o.OrderDate.Year == year).OrderBy(o => o.OrderDate).ThenBy(o => o.Id).LastOrDefault();

    public static Product? SecondCheapestProduct(IEnumerable<Product> products) =>
        products.OrderBy(p => p.UnitPrice).ThenBy(p => p.Name).Skip(1).FirstOrDefault();

    public static Employee EmployeeById(IEnumerable<Employee> employees, int employeeId) =>
        employees.Single(e => e.Id == employeeId);
}
