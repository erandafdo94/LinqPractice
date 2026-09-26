namespace LinqPractice.Answers;

public static class ConversionAnswers
{
    public static ILookup<string, int> OrderIdsByStatus() =>
        PracticeData.Orders
            .OrderBy(order => order.Id)
            .ToLookup(order => order.Status, order => order.Id);

    public static ILookup<int, Order> OrdersByCustomerId() =>
        PracticeData.Orders
            .OrderBy(order => order.OrderDate)
            .ThenBy(order => order.Id)
            .ToLookup(order => order.CustomerId);

    public static ILookup<string, string> ProductNamesByCategory() =>
        PracticeData.Products
            .OrderBy(product => product.Name)
            .ToLookup(product => product.Category, product => product.Name);
}
