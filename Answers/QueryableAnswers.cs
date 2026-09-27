namespace LinqPractice.Answers;

public static class QueryableAnswers
{
    public static IQueryable<Order> ShippedOrdersFrom(IQueryable<Order> orders, DateOnly fromDate) =>
        orders.Where(o => o.Status == "Shipped" && o.OrderDate >= fromDate)
            .OrderBy(o => o.OrderDate).ThenBy(o => o.Id);

    public static IQueryable<Order> OrdersForCustomer(IQueryable<Order> orders, int customerId) =>
        orders.Where(o => o.CustomerId == customerId).OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.Id);

    public static IQueryable<Order> OrderPage(IQueryable<Order> orders, int pageIndex, int pageSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(pageIndex); ArgumentOutOfRangeException.ThrowIfLessThan(pageSize, 1);
        return orders.OrderBy(o => o.OrderDate).ThenBy(o => o.Id).Skip(pageIndex * pageSize).Take(pageSize);
    }

    public static IQueryable<Product> ProductsInCategory(IQueryable<Product> products, string category) =>
        products.Where(p => p.Category == category).OrderBy(p => p.UnitPrice).ThenBy(p => p.Name);

    public static IQueryable<Product> ProductsAtMostPrice(IQueryable<Product> products, decimal maximumPrice) =>
        products.Where(p => p.UnitPrice <= maximumPrice).OrderBy(p => p.UnitPrice).ThenBy(p => p.Name);

    public static IQueryable<Customer> CustomersInCity(IQueryable<Customer> customers, string city) =>
        customers.Where(c => c.City == city).OrderBy(c => c.Name);

    public static IQueryable<Employee> EmployeesInDepartment(IQueryable<Employee> employees, int departmentId) =>
        employees.Where(e => e.DeptId == departmentId).OrderByDescending(e => e.Salary).ThenBy(e => e.Name);

    public static IQueryable<Order> OrdersWithStatus(IQueryable<Order> orders, string status) =>
        orders.Where(o => o.Status == status).OrderBy(o => o.OrderDate).ThenBy(o => o.Id);

    public static IQueryable<OrderItem> ItemsForOrder(IQueryable<OrderItem> orderItems, int orderId) =>
        orderItems.Where(i => i.OrderId == orderId).OrderBy(i => i.Id);

    public static IQueryable<Product> ProductPage(IQueryable<Product> products, int pageIndex, int pageSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(pageIndex); ArgumentOutOfRangeException.ThrowIfLessThan(pageSize, 1);
        return products.OrderBy(p => p.Name).Skip(pageIndex * pageSize).Take(pageSize);
    }
}
