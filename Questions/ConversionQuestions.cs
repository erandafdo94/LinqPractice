namespace LinqPractice.Questions;

public static class ConversionQuestions
{
    // Write your LINQ answers below.
    // CONVERT-01 — Look up order IDs by status
    // Build an ILookup where each key is an order Status and each value is an order ID. Ensure
    // IDs inside each group are ascending. Asking for an unknown status should return no values.
    public static ILookup<string, int> OrderIdsByStatus(IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // CONVERT-02 — Look up orders by customer
    // Build an ILookup keyed by CustomerId whose values are complete Order objects. Orders for
    // each customer must be oldest first, with ID used to break same-date ties.
    public static ILookup<int, Order> OrdersByCustomerId(IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // CONVERT-03 — Look up product names by category
    // Build an ILookup from Category to product Name. Names within each category must be
    // alphabetical, and requesting a category that does not exist should return an empty sequence.
    public static ILookup<string, string> ProductNamesByCategory(IEnumerable<Product> products) =>
        throw new NotImplementedException();
}
