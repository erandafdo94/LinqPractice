namespace LinqPractice.Answers;

public static class WhereAnswers
{
    public static IReadOnlyList<string> AucklandCustomerNames() =>
        PracticeData.Customers
            .Where(customer => customer.City == "Auckland")
            .OrderBy(customer => customer.Name)
            .Select(customer => customer.Name)
            .ToList();

    public static IReadOnlyList<string> ProductsPricedBetween(decimal minimum, decimal maximum) =>
        PracticeData.Products
            .Where(product => product.UnitPrice >= minimum && product.UnitPrice <= maximum)
            .OrderBy(product => product.UnitPrice)
            .ThenBy(product => product.Name)
            .Select(product => product.Name)
            .ToList();

    public static IReadOnlyList<int> ShippedOrderIdsInYear(int year) =>
        PracticeData.Orders
            .Where(order => order.Status == "Shipped" && order.OrderDate.Year == year)
            .OrderBy(order => order.OrderDate)
            .ThenBy(order => order.Id)
            .Select(order => order.Id)
            .ToList();
}
