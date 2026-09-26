namespace LinqPractice.Answers;

public static class SetAnswers
{
    private static IEnumerable<string> CustomersWhoOrderedProduct(string productName) =>
        from customer in PracticeData.Customers
        join order in PracticeData.Orders on customer.Id equals order.CustomerId
        join item in PracticeData.OrderItems on order.Id equals item.OrderId
        join product in PracticeData.Products on item.ProductId equals product.Id
        where product.Name == productName
        select customer.Name;

    public static IReadOnlyList<string> DistinctCustomerCitiesWithOrders() =>
        (from customer in PracticeData.Customers
         join order in PracticeData.Orders on customer.Id equals order.CustomerId
         select customer.City)
        .Distinct()
        .OrderBy(city => city)
        .ToList();

    public static IReadOnlyList<string> CustomersNeedingFollowUp()
    {
        var pending = from customer in PracticeData.Customers
                      join order in PracticeData.Orders on customer.Id equals order.CustomerId
                      where order.Status == "Pending"
                      select customer.Name;

        var cancelled = from customer in PracticeData.Customers
                        join order in PracticeData.Orders on customer.Id equals order.CustomerId
                        where order.Status == "Cancelled"
                        select customer.Name;

        return pending.Union(cancelled).OrderBy(name => name).ToList();
    }

    public static IReadOnlyList<string> CustomersWhoOrderedMonitorAndMouse() =>
        CustomersWhoOrderedProduct("Monitor")
            .Intersect(CustomersWhoOrderedProduct("Mouse"))
            .OrderBy(name => name)
            .ToList();

    public static IReadOnlyList<string> ProductsNeverShipped()
    {
        var shippedProductIds =
            from order in PracticeData.Orders
            where order.Status == "Shipped"
            join item in PracticeData.OrderItems on order.Id equals item.OrderId
            select item.ProductId;

        return PracticeData.Products
            .ExceptBy(shippedProductIds, product => product.Id)
            .OrderBy(product => product.Name)
            .Select(product => product.Name)
            .ToList();
    }
}
