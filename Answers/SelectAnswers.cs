namespace LinqPractice.Answers;

public static class SelectAnswers
{
    public static IReadOnlyList<(string Name, string Category, decimal Price)> ProductCatalog(IEnumerable<Product> products) =>
        products.OrderBy(p => p.Name).Select(p => (p.Name, p.Category, p.UnitPrice)).ToList();

    public static IReadOnlyList<string> UppercaseEmployeeNames(IEnumerable<Employee> employees) =>
        employees.Select(e => e.Name.ToUpperInvariant()).OrderBy(name => name).ToList();

    public static IReadOnlyList<(int OrderItemId, decimal LineTotal)> OrderItemTotals(IEnumerable<OrderItem> orderItems) =>
        orderItems.OrderBy(i => i.Id).Select(i => (i.Id, i.Quantity * i.UnitPrice)).ToList();

    public static IReadOnlyList<string> CustomerLabels(IEnumerable<Customer> customers) =>
        customers.OrderBy(c => c.Name).Select(c => $"{c.Name} — {c.City}").ToList();

    public static IReadOnlyList<(string Name, decimal MonthlySalary)> EmployeeMonthlySalaries(IEnumerable<Employee> employees) =>
        employees.OrderBy(e => e.Name).Select(e => (e.Name, e.Salary / 12m)).ToList();

    public static IReadOnlyList<(int Id, string Status, DateOnly OrderDate)> OrderSummaries(IEnumerable<Order> orders) =>
        orders.OrderBy(o => o.OrderDate).ThenBy(o => o.Id).Select(o => (o.Id, o.Status, o.OrderDate)).ToList();

    public static IReadOnlyList<(string Name, decimal PriceWithTax)> ProductPricesWithTax(IEnumerable<Product> products, decimal taxRate) =>
        products.OrderBy(p => p.Name).Select(p => (p.Name, p.UnitPrice * (1m + taxRate))).ToList();

    public static IReadOnlyList<(int OrderId, int ProductId, int Quantity)> OrderItemSummaries(IEnumerable<OrderItem> orderItems) =>
        orderItems.OrderBy(i => i.OrderId).ThenBy(i => i.Id)
            .Select(i => (i.OrderId, i.ProductId, i.Quantity)).ToList();

    public static IReadOnlyList<(string Value, string Text)> DepartmentOptions(IEnumerable<Department> departments) =>
        departments.OrderBy(d => d.Name).Select(d => (d.Id.ToString(), d.Name)).ToList();

    public static IReadOnlyList<(string Name, int CompleteYears)> CustomerMembershipYears(
        IEnumerable<Customer> customers, DateOnly asOfDate) =>
        customers.OrderBy(c => c.Name).Select(c =>
        {
            var years = asOfDate.Year - c.SignupDate.Year;
            if (asOfDate < c.SignupDate.AddYears(Math.Max(years, 0))) years--;
            return (c.Name, Math.Max(years, 0));
        }).ToList();
}
