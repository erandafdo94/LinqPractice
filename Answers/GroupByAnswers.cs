namespace LinqPractice.Answers;

public static class GroupByAnswers
{
    public static IReadOnlyList<(string City, int CustomerCount)> CustomerCountByCity(
        IEnumerable<Customer> customers) =>
        customers
            .GroupBy(customer => customer.City)
            .OrderBy(group => group.Key)
            .Select(group => (group.Key, group.Count()))
            .ToList();

    public static IReadOnlyList<(int Year, int Month, string Status, int Count)> MonthlyOrderStatusSummary(
        IEnumerable<Order> orders) =>
        orders
            .GroupBy(order => new { order.OrderDate.Year, order.OrderDate.Month, order.Status })
            .OrderBy(group => group.Key.Year)
            .ThenBy(group => group.Key.Month)
            .ThenBy(group => group.Key.Status)
            .Select(group => (group.Key.Year, group.Key.Month, group.Key.Status, group.Count()))
            .ToList();

    public static IReadOnlyList<(string Category, int ProductCount, decimal AveragePrice, decimal HighestPrice)> CategoryPriceSummary(
        IEnumerable<Product> products) =>
        products
            .GroupBy(product => product.Category)
            .OrderBy(group => group.Key)
            .Select(group =>
                (group.Key, group.Count(), group.Average(product => product.UnitPrice),
                    group.Max(product => product.UnitPrice)))
            .ToList();

    public static IReadOnlyList<(string Category, string Product, decimal Price)> HighestPricedProductByCategory(
        IEnumerable<Product> products) =>
        products
            .GroupBy(product => product.Category)
            .OrderBy(group => group.Key)
            .Select(group =>
            {
                var product = group.MaxBy(item => item.UnitPrice)!;
                return (group.Key, product.Name, product.UnitPrice);
            })
            .ToList();
}
