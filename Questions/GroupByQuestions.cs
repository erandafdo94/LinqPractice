namespace LinqPractice.Questions;

public static class GroupByQuestions
{
    // Write your LINQ answers below.

    // GROUP-01 — Customer count by city
    // The reporting team wants one row per city. Group `customers` by City, return each city
    // with the number of customers who live there, and sort the rows alphabetically by city.
    public static IReadOnlyList<(string City, int CustomerCount)> CustomerCountByCity(
        IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // GROUP-02 — Monthly order-status summary
    // Group orders using a composite key of OrderDate.Year, OrderDate.Month, and Status. Return
    // the key values plus Count, ordered chronologically and then alphabetically by status.
    public static IReadOnlyList<(int Year, int Month, string Status, int Count)> MonthlyOrderStatusSummary(
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // GROUP-03 — Category price statistics
    // Produce one row per product category containing ProductCount, AveragePrice, and HighestPrice.
    // Sort categories alphabetically. All calculations should use UnitPrice.
    public static IReadOnlyList<(string Category, int ProductCount, decimal AveragePrice, decimal HighestPrice)> CategoryPriceSummary(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // GROUP-04 — Most expensive product per category
    // Group products by Category and select the product with the highest UnitPrice from each
    // group. Return Category, Product name, and Price, ordered alphabetically by category.
    public static IReadOnlyList<(string Category, string Product, decimal Price)> HighestPricedProductByCategory(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();
}
