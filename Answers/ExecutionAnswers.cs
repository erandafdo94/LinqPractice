namespace LinqPractice.Answers;

public static class ExecutionAnswers
{
    public static IEnumerable<string> ExpensiveProductNamesDeferred(IEnumerable<Product> products, decimal minimumPrice) =>
        products.Where(p => p.UnitPrice > minimumPrice).OrderBy(p => p.Name).Select(p => p.Name);

    public static IReadOnlyList<string> ExpensiveProductNamesSnapshot(IEnumerable<Product> products, decimal minimumPrice) =>
        products.Where(p => p.UnitPrice > minimumPrice).OrderBy(p => p.Name).Select(p => p.Name).ToList();

    public static int ProductCountSnapshot(IEnumerable<Product> products, string category) =>
        products.Count(p => p.Category == category);

    public static IEnumerable<string> CustomerNamesByCityDeferred(IEnumerable<Customer> customers, string city) =>
        customers.Where(c => c.City == city).OrderBy(c => c.Name).Select(c => c.Name);

    public static IReadOnlyList<string> CustomerNamesByCitySnapshot(IEnumerable<Customer> customers, string city) =>
        customers.Where(c => c.City == city).OrderBy(c => c.Name).Select(c => c.Name).ToList();

    public static IEnumerable<int> OrderIdsByStatusDeferred(IEnumerable<Order> orders, string status) =>
        orders.Where(o => o.Status == status).OrderBy(o => o.OrderDate).ThenBy(o => o.Id).Select(o => o.Id);

    public static IReadOnlyList<int> OrderIdsByStatusSnapshot(IEnumerable<Order> orders, string status) =>
        orders.Where(o => o.Status == status).OrderBy(o => o.OrderDate).ThenBy(o => o.Id).Select(o => o.Id).ToList();

    public static IEnumerable<(string Name, decimal Price)> ProductPricesDeferred(IEnumerable<Product> products) =>
        products.OrderBy(p => p.Name).Select(p => (p.Name, p.UnitPrice));

    public static IReadOnlyList<(string Name, decimal Price)> ProductPricesSnapshot(IEnumerable<Product> products) =>
        products.OrderBy(p => p.Name).Select(p => (p.Name, p.UnitPrice)).ToList();

    public static IEnumerable<string> SalaryLeaderboardDeferred(IEnumerable<Employee> employees) =>
        employees.OrderByDescending(e => e.Salary).ThenBy(e => e.Name).Select(e => e.Name);
}
