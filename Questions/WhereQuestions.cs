namespace LinqPractice.Questions;

public static class WhereQuestions
{
    // Write your LINQ answers below.
    // WHERE-01 — Customers in one city
    // The sales team needs a mailing list for Auckland. From `customers`, keep only people
    // whose City is "Auckland", return their names, and sort the names alphabetically.
    public static IReadOnlyList<string> AucklandCustomerNames(IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // WHERE-02 — Products within a budget
    // A shopper provides a minimum and maximum budget. From `products`, return the names of
    // products whose price is inside that range, including both limits. Sort by price from
    // lowest to highest, then by name when two products have the same price.
    public static IReadOnlyList<string> ProductsPricedBetween(
        IEnumerable<Product> products,
        decimal minimum,
        decimal maximum) =>
        throw new NotImplementedException();

    // WHERE-03 — Shipped orders for a year
    // From `orders`, find orders that were shipped during the supplied calendar year.
    // Return only their IDs, ordered by OrderDate and then by ID for deterministic results.
    public static IReadOnlyList<int> ShippedOrderIdsInYear(IEnumerable<Order> orders, int year) =>
        throw new NotImplementedException();
}
