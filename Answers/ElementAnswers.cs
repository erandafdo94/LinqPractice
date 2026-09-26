namespace LinqPractice.Answers;

public static class ElementAnswers
{
    public static Order? FirstShippedOrder() =>
        PracticeData.Orders
            .Where(order => order.Status == "Shipped")
            .OrderBy(order => order.OrderDate)
            .ThenBy(order => order.Id)
            .FirstOrDefault();

    public static Product? ProductByExactName(IEnumerable<Product> products, string name) =>
        products.SingleOrDefault(product => product.Name == name);

    public static Order? LatestOrderOrDefault(int customerId) =>
        PracticeData.Orders
            .Where(order => order.CustomerId == customerId)
            .OrderByDescending(order => order.OrderDate)
            .ThenByDescending(order => order.Id)
            .FirstOrDefault();

    public static Product? CheapestProduct(IEnumerable<Product> products) =>
        products.MinBy(product => product.UnitPrice);
}
