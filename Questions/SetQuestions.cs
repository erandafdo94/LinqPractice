namespace LinqPractice.Questions;

public static class SetQuestions
{
    // Write your LINQ answers below.
    // SET-01 — Cities containing active customers
    // Difficulty: Simple
    // Match customers to orders, select their cities, remove duplicates, and return the city
    // names alphabetically. Customers without orders must not contribute a city.
    public static IReadOnlyList<string> DistinctCustomerCitiesWithOrders(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // SET-02 — Customers needing follow-up
    // Difficulty: Simple
    // Build one sequence of customers with pending orders and another with cancelled orders.
    // Combine them as a set so each customer appears once, then return names alphabetically.
    public static IReadOnlyList<string> CustomersNeedingFollowUp(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // SET-03 — Customers who bought both products
    // Difficulty: Simple
    // Find customers who ordered a product named "Monitor" and customers who ordered "Mouse".
    // Return the intersection of those customer-name sets, without duplicates and alphabetically.
    public static IReadOnlyList<string> CustomersWhoOrderedMonitorAndMouse(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems,
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // SET-04 — Products that have never shipped
    // Difficulty: Medium
    // Start with all products, then exclude products whose IDs appear in items belonging to a
    // shipped order. A product may still qualify if it appears only in pending or cancelled orders.
    public static IReadOnlyList<string> ProductsNeverShipped(
        IEnumerable<Product> products,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // SET-05 — Combine customer and employee names
    // Difficulty: Medium
    // Concatenate customer names followed by employee names without removing duplicates. Return
    // the combined sequence in source order; this question specifically practices Concat.
    public static IReadOnlyList<string> CustomerAndEmployeeNames(
        IEnumerable<Customer> customers, IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // SET-06 — One representative customer per city
    // Difficulty: Medium
    // Sort customers by name, then keep the first customer for each City using DistinctBy.
    // Return the selected customer names ordered by city.
    public static IReadOnlyList<string> FirstCustomerNameByCity(
        IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // SET-07 — Unique people names across two sources
    // Difficulty: Medium
    // Union customer names with employee names so duplicates are removed, then sort all names
    // alphabetically using ordinal comparison.
    public static IReadOnlyList<string> UniqueCustomerAndEmployeeNames(
        IEnumerable<Customer> customers, IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // SET-08 — Customers without orders
    // Difficulty: Hard
    // Use a set-difference operator to remove customers whose IDs appear in orders. Return the
    // remaining customer names alphabetically.
    public static IReadOnlyList<string> CustomersWithoutOrders(
        IEnumerable<Customer> customers, IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // SET-09 — Customers with shipped and pending orders
    // Difficulty: Hard
    // Build customer-ID sets for shipped and pending orders, intersect them, then resolve the
    // matching customer names alphabetically.
    public static IReadOnlyList<string> CustomersWithShippedAndPendingOrders(
        IEnumerable<Customer> customers, IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // SET-10 — Products bought in one year but not another
    // Difficulty: Hard
    // Find product IDs appearing in `includedYear`, exclude IDs appearing in `excludedYear`, and
    // return the remaining product names alphabetically without duplicates.
    public static IReadOnlyList<string> ProductsOrderedInYearButNotAnother(
        IEnumerable<Product> products,
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems,
        int includedYear,
        int excludedYear) =>
        throw new NotImplementedException();
}
