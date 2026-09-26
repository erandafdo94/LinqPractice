namespace LinqPractice.Questions;

public static class ExecutionQuestions
{
    // Write your LINQ answers below.
    // EXEC-01 — A query that sees later changes
    // Compose and return an alphabetical sequence of product names priced strictly above
    // `minimumPrice`. Do not enumerate or materialize it; a product added before enumeration
    // must appear in the result.
    public static IEnumerable<string> ExpensiveProductNamesDeferred(
        IEnumerable<Product> products,
        decimal minimumPrice) =>
        throw new NotImplementedException();

    // EXEC-02 — A snapshot that ignores later changes
    // Return an alphabetical list of product names priced strictly above `minimumPrice`.
    // Materialize the result before returning so later changes to `products` are not visible.
    public static IReadOnlyList<string> ExpensiveProductNamesSnapshot(
        IEnumerable<Product> products,
        decimal minimumPrice) =>
        throw new NotImplementedException();

    // EXEC-03 — Count immediately
    // Count products whose Category exactly matches `category` and return the integer now.
    // This scalar terminal operation must execute before the method returns.
    public static int ProductCountSnapshot(IEnumerable<Product> products, string category) =>
        throw new NotImplementedException();
}
