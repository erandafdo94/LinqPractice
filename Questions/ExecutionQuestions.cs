namespace LinqPractice.Questions;

public static class ExecutionQuestions
{
    // Write your LINQ answers below.
    // EXEC-01 — A query that sees later changes
    // Difficulty: Simple
    // Compose and return an alphabetical sequence of product names priced strictly above
    // `minimumPrice`. Do not enumerate or materialize it; a product added before enumeration
    // must appear in the result.
    public static IEnumerable<string> ExpensiveProductNamesDeferred(
        IEnumerable<Product> products,
        decimal minimumPrice) =>
        throw new NotImplementedException();

    // EXEC-02 — A snapshot that ignores later changes
    // Difficulty: Simple
    // Return an alphabetical list of product names priced strictly above `minimumPrice`.
    // Materialize the result before returning so later changes to `products` are not visible.
    public static IReadOnlyList<string> ExpensiveProductNamesSnapshot(
        IEnumerable<Product> products,
        decimal minimumPrice) =>
        throw new NotImplementedException();

    // EXEC-03 — Count immediately
    // Difficulty: Simple
    // Count products whose Category exactly matches `category` and return the integer now.
    // This scalar terminal operation must execute before the method returns.
    public static int ProductCountSnapshot(IEnumerable<Product> products, string category) =>
        throw new NotImplementedException();

    // EXEC-04 — Deferred customer names by city
    // Difficulty: Medium
    // Return an unmaterialized alphabetical query of names for customers in `city`. Customers
    // added before enumeration must be observed.
    public static IEnumerable<string> CustomerNamesByCityDeferred(
        IEnumerable<Customer> customers, string city) =>
        throw new NotImplementedException();

    // EXEC-05 — Customer-name snapshot by city
    // Difficulty: Medium
    // Return a materialized alphabetical list of names for customers in `city`. Later changes to
    // the source must not change the returned list.
    public static IReadOnlyList<string> CustomerNamesByCitySnapshot(
        IEnumerable<Customer> customers, string city) =>
        throw new NotImplementedException();

    // EXEC-06 — Deferred order IDs by status
    // Difficulty: Medium
    // Compose an unmaterialized chronological sequence of IDs for orders with `status`. Do not
    // call ToList, ToArray, Count, or another terminal operator.
    public static IEnumerable<int> OrderIdsByStatusDeferred(
        IEnumerable<Order> orders, string status) =>
        throw new NotImplementedException();

    // EXEC-07 — Order-ID snapshot by status
    // Difficulty: Medium
    // Return a materialized chronological list of IDs for orders with `status`, insulated from
    // later changes to the source collection.
    public static IReadOnlyList<int> OrderIdsByStatusSnapshot(
        IEnumerable<Order> orders, string status) =>
        throw new NotImplementedException();

    // EXEC-08 — Deferred product price projection
    // Difficulty: Hard
    // Return an unmaterialized sequence of (Name, Price), ordered by name. Changes to product
    // prices made before enumeration must be reflected.
    public static IEnumerable<(string Name, decimal Price)> ProductPricesDeferred(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // EXEC-09 — Product price snapshot
    // Difficulty: Hard
    // Return a materialized alphabetical list of (Name, Price). Replacing or adding products after
    // this method returns must not affect the result.
    public static IReadOnlyList<(string Name, decimal Price)> ProductPricesSnapshot(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // EXEC-10 — Deferred salary leaderboard
    // Difficulty: Hard
    // Compose an unmaterialized sequence of employee names ordered by Salary descending and Name.
    // Do not enumerate the employee source inside this method.
    public static IEnumerable<string> SalaryLeaderboardDeferred(
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();
}
