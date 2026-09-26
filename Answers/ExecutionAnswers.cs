namespace LinqPractice.Answers;

public static class ExecutionAnswers
{
    public static IEnumerable<string> ExpensiveProductNamesDeferred(
        IEnumerable<Product> products,
        decimal minimumPrice) =>
        products
            .Where(product => product.UnitPrice > minimumPrice)
            .OrderBy(product => product.Name)
            .Select(product => product.Name);

    public static IReadOnlyList<string> ExpensiveProductNamesSnapshot(
        IEnumerable<Product> products,
        decimal minimumPrice) =>
        products
            .Where(product => product.UnitPrice > minimumPrice)
            .OrderBy(product => product.Name)
            .Select(product => product.Name)
            .ToList();

    public static int ProductCountSnapshot(IEnumerable<Product> products, string category) =>
        products.Count(product => product.Category == category);
}
