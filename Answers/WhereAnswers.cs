namespace LinqPractice.Answers;

public static class WhereAnswers
{
    public static IReadOnlyList<string> AucklandCustomerNames(IEnumerable<Customer> customers) =>
        customers.Where(c => c.City == "Auckland").OrderBy(c => c.Name).Select(c => c.Name).ToList();

    public static IReadOnlyList<string> ProductsPricedBetween(IEnumerable<Product> products, decimal minimum, decimal maximum) =>
        products.Where(p => p.UnitPrice >= minimum && p.UnitPrice <= maximum)
            .OrderBy(p => p.UnitPrice).ThenBy(p => p.Name).Select(p => p.Name).ToList();

    public static IReadOnlyList<int> ShippedOrderIdsInYear(IEnumerable<Order> orders, int year) =>
        orders.Where(o => o.Status == "Shipped" && o.OrderDate.Year == year)
            .OrderBy(o => o.OrderDate).ThenBy(o => o.Id).Select(o => o.Id).ToList();

    public static IReadOnlyList<string> EmployeesEarningAtLeast(IEnumerable<Employee> employees, decimal minimumSalary) =>
        employees.Where(e => e.Salary >= minimumSalary).OrderByDescending(e => e.Salary)
            .ThenBy(e => e.Name).Select(e => e.Name).ToList();

    public static IReadOnlyList<string> CustomersSignedUpFrom(IEnumerable<Customer> customers, DateOnly fromDate) =>
        customers.Where(c => c.SignupDate >= fromDate).OrderBy(c => c.SignupDate)
            .ThenBy(c => c.Name).Select(c => c.Name).ToList();

    public static IReadOnlyList<int> OrdersWithStatusFrom(IEnumerable<Order> orders, string status, DateOnly fromDate) =>
        orders.Where(o => o.Status == status && o.OrderDate >= fromDate).OrderBy(o => o.OrderDate)
            .ThenBy(o => o.Id).Select(o => o.Id).ToList();

    public static IReadOnlyList<string> ProductsInCategoryUnder(IEnumerable<Product> products, string category, decimal maximumPrice) =>
        products.Where(p => p.Category == category && p.UnitPrice <= maximumPrice)
            .OrderBy(p => p.UnitPrice).ThenBy(p => p.Name).Select(p => p.Name).ToList();

    public static IReadOnlyList<string> UnassignedEmployeeNames(IEnumerable<Employee> employees) =>
        employees.Where(e => e.DeptId is null).OrderBy(e => e.Name).Select(e => e.Name).ToList();

    public static IReadOnlyList<int> LargeOrderItemIds(IEnumerable<OrderItem> orderItems, int minimumQuantity) =>
        orderItems.Where(i => i.Quantity >= minimumQuantity).OrderByDescending(i => i.Quantity)
            .ThenBy(i => i.Id).Select(i => i.Id).ToList();

    public static IReadOnlyList<int> OrdersInDateRange(IEnumerable<Order> orders, DateOnly startDate, DateOnly endDate) =>
        orders.Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
            .OrderBy(o => o.OrderDate).ThenBy(o => o.Id).Select(o => o.Id).ToList();
}
