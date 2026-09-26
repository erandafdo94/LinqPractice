namespace LinqPractice.Answers;

public static class SelectAnswers
{
    public static IReadOnlyList<(string Name, string Category, decimal Price)> ProductCatalog() =>
        PracticeData.Products
            .OrderBy(product => product.Name)
            .Select(product => (product.Name, product.Category, product.UnitPrice))
            .ToList();

    public static IReadOnlyList<string> UppercaseEmployeeNames() =>
        PracticeData.Employees
            .Select(employee => employee.Name.ToUpperInvariant())
            .OrderBy(name => name)
            .ToList();

    public static IReadOnlyList<(int OrderItemId, decimal LineTotal)> OrderItemTotals() =>
        PracticeData.OrderItems
            .OrderBy(item => item.Id)
            .Select(item => (item.Id, item.Quantity * item.UnitPrice))
            .ToList();
}
