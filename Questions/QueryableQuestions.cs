namespace LinqPractice.Questions;

public static class QueryableQuestions
{
    // Write your LINQ answers below.
    // QUERY-01 — Compose a shipped-orders database query
    // Return an IQueryable containing shipped orders on or after `fromDate`, ordered by
    // OrderDate and ID. Do not call ToList, AsEnumerable, or otherwise enumerate the query.
    public static IQueryable<Order> ShippedOrdersFrom(IQueryable<Order> orders, DateOnly fromDate) =>
        throw new NotImplementedException();

    // QUERY-02 — Compose a customer's order-history query
    // Filter the IQueryable to `customerId` and order newest first by OrderDate and then ID.
    // Keep the result as IQueryable so a database provider can translate the entire expression.
    public static IQueryable<Order> OrdersForCustomer(IQueryable<Order> orders, int customerId) =>
        throw new NotImplementedException();

    // QUERY-03 — Compose provider-side pagination
    // Treat `pageIndex` as zero-based. Order by OrderDate and ID, then apply Skip and Take while
    // the source is still IQueryable. Reject negative indexes and page sizes below 1.
    public static IQueryable<Order> OrderPage(IQueryable<Order> orders, int pageIndex, int pageSize) =>
        throw new NotImplementedException();
}
