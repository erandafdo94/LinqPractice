namespace LinqPractice.Questions;

public static class SetQuestions
{
    // Write your LINQ answers below.
    // SET-01 — Cities containing active customers
    // Match customers to orders, select their cities, remove duplicates, and return the city
    // names alphabetically. Customers without orders must not contribute a city.
    public static IReadOnlyList<string> DistinctCustomerCitiesWithOrders(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // SET-02 — Customers needing follow-up
    // Build one sequence of customers with pending orders and another with cancelled orders.
    // Combine them as a set so each customer appears once, then return names alphabetically.
    public static IReadOnlyList<string> CustomersNeedingFollowUp(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // SET-03 — Customers who bought both products
    // Find customers who ordered a product named "Monitor" and customers who ordered "Mouse".
    // Return the intersection of those customer-name sets, without duplicates and alphabetically.
    public static IReadOnlyList<string> CustomersWhoOrderedMonitorAndMouse(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems,
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // SET-04 — Products that have never shipped
    // Start with all products, then exclude products whose IDs appear in items belonging to a
    // shipped order. A product may still qualify if it appears only in pending or cancelled orders.
    public static IReadOnlyList<string> ProductsNeverShipped(
        IEnumerable<Product> products,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();
}
