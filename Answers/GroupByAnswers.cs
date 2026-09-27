namespace LinqPractice.Answers;

public static class GroupByAnswers
{
    public static IReadOnlyList<(string City, int CustomerCount)> CustomerCountByCity(IEnumerable<Customer> customers) =>
        customers.GroupBy(c => c.City).OrderBy(g => g.Key).Select(g => (g.Key, g.Count())).ToList();

    public static IReadOnlyList<(int Year, int Month, string Status, int Count)> MonthlyOrderStatusSummary(IEnumerable<Order> orders) =>
        orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month, o.Status })
            .OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Month).ThenBy(g => g.Key.Status)
            .Select(g => (g.Key.Year, g.Key.Month, g.Key.Status, g.Count())).ToList();

    public static IReadOnlyList<(string Category, int ProductCount, decimal AveragePrice, decimal HighestPrice)> CategoryPriceSummary(
        IEnumerable<Product> products) =>
        products.GroupBy(p => p.Category).OrderBy(g => g.Key)
            .Select(g => (g.Key, g.Count(), g.Average(p => p.UnitPrice), g.Max(p => p.UnitPrice))).ToList();

    public static IReadOnlyList<(string Category, string Product, decimal Price)> HighestPricedProductByCategory(
        IEnumerable<Product> products) =>
        products.GroupBy(p => p.Category).OrderBy(g => g.Key).Select(g =>
        {
            var p = g.OrderBy(p => p.Name).MaxBy(p => p.UnitPrice)!;
            return (g.Key, p.Name, p.UnitPrice);
        }).ToList();

    public static IReadOnlyList<(int DepartmentId, int EmployeeCount, decimal AverageSalary)> SalarySummaryByDepartmentId(
        IEnumerable<Employee> employees) =>
        employees.Where(e => e.DeptId.HasValue).GroupBy(e => e.DeptId!.Value).OrderBy(g => g.Key)
            .Select(g => (g.Key, g.Count(), g.Average(e => e.Salary))).ToList();

    public static IReadOnlyList<(int CustomerId, int OrderCount)> OrderCountByCustomerId(IEnumerable<Order> orders) =>
        orders.GroupBy(o => o.CustomerId).OrderBy(g => g.Key).Select(g => (g.Key, g.Count())).ToList();

    public static IReadOnlyList<(string Band, int ProductCount)> ProductCountByPriceBand(IEnumerable<Product> products)
    {
        static string Band(Product p) => p.UnitPrice < 100m ? "Budget" : p.UnitPrice < 300m ? "Standard" : "Premium";
        var order = new Dictionary<string, int> { ["Budget"] = 0, ["Standard"] = 1, ["Premium"] = 2 };
        return products.GroupBy(Band).OrderBy(g => order[g.Key]).Select(g => (g.Key, g.Count())).ToList();
    }

    public static IReadOnlyList<(int Year, int CustomerCount)> CustomerSignupsByYear(IEnumerable<Customer> customers) =>
        customers.GroupBy(c => c.SignupDate.Year).OrderBy(g => g.Key).Select(g => (g.Key, g.Count())).ToList();

    public static IReadOnlyList<(int ProductId, int TotalUnits)> UnitsByProductId(IEnumerable<OrderItem> items) =>
        items.GroupBy(i => i.ProductId).OrderBy(g => g.Key).Select(g => (g.Key, g.Sum(i => i.Quantity))).ToList();

    public static IReadOnlyList<(decimal Salary, string Employees)> EmployeesSharingSalary(IEnumerable<Employee> employees) =>
        employees.GroupBy(e => e.Salary).Where(g => g.Count() > 1).OrderByDescending(g => g.Key)
            .Select(g => (g.Key, string.Join(", ", g.OrderBy(e => e.Name).Select(e => e.Name)))).ToList();
}
