namespace LinqPractice.Questions;

public static class ElementQuestions
{
    // Write your LINQ answers below.
    // ELEMENT-01 — Find the first shipped order
    // Filter to shipped orders and return the earliest one by OrderDate, using ID as a tie-breaker.
    // Return null when the input contains no shipped orders.
    public static Order? FirstShippedOrder(IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // ELEMENT-02 — Enforce a unique product name
    // Find the single product whose Name exactly matches `name`. Return null when none matches,
    // but let SingleOrDefault throw when duplicate names violate the uniqueness assumption.
    public static Product? ProductByExactName(IEnumerable<Product> products, string name) =>
        throw new NotImplementedException();

    // ELEMENT-03 — Find a customer's latest order
    // Keep orders belonging to `customerId`, then return the newest by OrderDate and ID.
    // Return null if that customer has never placed an order.
    public static Order? LatestOrderOrDefault(IEnumerable<Order> orders, int customerId) =>
        throw new NotImplementedException();

    // ELEMENT-04 — Find the cheapest product
    // Return the Product with the lowest UnitPrice. The method must also handle an empty input
    // sequence by returning null instead of throwing.
    public static Product? CheapestProduct(IEnumerable<Product> products) =>
        throw new NotImplementedException();
}
