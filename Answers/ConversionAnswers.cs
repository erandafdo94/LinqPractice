namespace LinqPractice.Answers;

public static class ConversionAnswers
{
    public static ILookup<string, int> OrderIdsByStatus(IEnumerable<Order> orders) =>
        orders.OrderBy(o => o.Id).ToLookup(o => o.Status, o => o.Id);

    public static ILookup<int, Order> OrdersByCustomerId(IEnumerable<Order> orders) =>
        orders.OrderBy(o => o.OrderDate).ThenBy(o => o.Id).ToLookup(o => o.CustomerId);

    public static ILookup<string, string> ProductNamesByCategory(IEnumerable<Product> products) =>
        products.OrderBy(p => p.Name).ToLookup(p => p.Category, p => p.Name);

    public static ILookup<int?, Employee> EmployeesByDepartmentId(IEnumerable<Employee> employees) =>
        employees.OrderBy(e => e.Name).ToLookup(e => e.DeptId);

    public static ILookup<int, OrderItem> OrderItemsByOrderId(IEnumerable<OrderItem> orderItems) =>
        orderItems.OrderBy(i => i.Id).ToLookup(i => i.OrderId);

    public static ILookup<string, string> CustomerNamesByCity(IEnumerable<Customer> customers) =>
        customers.OrderBy(c => c.Name).ToLookup(c => c.City, c => c.Name);

    public static ILookup<char, string> ProductNamesByFirstLetter(IEnumerable<Product> products) =>
        products.OrderBy(p => p.Name).ToLookup(p => char.ToUpperInvariant(p.Name[0]), p => p.Name);

    public static ILookup<int, int> OrderIdsByYear(IEnumerable<Order> orders) =>
        orders.OrderBy(o => o.OrderDate).ThenBy(o => o.Id).ToLookup(o => o.OrderDate.Year, o => o.Id);

    public static ILookup<int?, string> EmployeeNamesByManagerId(IEnumerable<Employee> employees) =>
        employees.OrderBy(e => e.Name).ToLookup(e => e.ManagerId, e => e.Name);

    public static ILookup<string, int> ProductIdsByPriceBand(IEnumerable<Product> products)
    {
        static string Band(Product p) => p.UnitPrice < 100m ? "Budget" : p.UnitPrice < 300m ? "Standard" : "Premium";
        return products.OrderBy(p => p.UnitPrice).ThenBy(p => p.Id).ToLookup(Band, p => p.Id);
    }
}
