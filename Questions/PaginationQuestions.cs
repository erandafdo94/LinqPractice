namespace LinqPractice.Questions;

public static class PaginationQuestions
{
    // Write your LINQ answers below.
    // PAGE-01 — Display one page of products
    // Treat `pageNumber` as one-based. Order products by price descending and then by name,
    // skip the earlier pages, and return only the names on the requested page. Reject page
    // numbers or page sizes below 1 with ArgumentOutOfRangeException.
    public static IReadOnlyList<string> ProductPage(
        IEnumerable<Product> products,
        int pageNumber,
        int pageSize) =>
        throw new NotImplementedException();

    // PAGE-02 — Top-paid employees
    // Return the names of the `count` highest-paid employees. Sort by salary descending and
    // name ascending to resolve ties. A count of zero returns an empty list; reject negatives.
    public static IReadOnlyList<string> TopHighestPaid(IEnumerable<Employee> employees, int count) =>
        throw new NotImplementedException();

    // PAGE-03 — Batch IDs for an external API
    // An API accepts only `batchSize` order IDs per request. Sort IDs ascending, split them into
    // chunks, and return each chunk as a comma-separated string. Reject batch sizes below 1.
    public static IReadOnlyList<string> OrderIdBatches(IEnumerable<Order> orders, int batchSize) =>
        throw new NotImplementedException();
}
