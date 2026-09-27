namespace LinqPractice.Answers;

public static class AllAnswers
{
    public static bool AreAllOrdersFinalized(IEnumerable<Order> orders) =>
        orders.All(o => o.Status is "Shipped" or "Cancelled");

    public static IReadOnlyList<string> DepartmentsWhereEveryoneEarnsAtLeast(
        IEnumerable<Department> departments, IEnumerable<Employee> employees, decimal minimumSalary)
    {
        var list = employees.ToList();
        return departments.Where(d =>
        {
            var matches = list.Where(e => e.DeptId == d.Id).ToList();
            return matches.Any() && matches.All(e => e.Salary >= minimumSalary);
        }).OrderBy(d => d.Name).Select(d => d.Name).ToList();
    }

    public static IReadOnlyList<string> CustomersWithOnlyShippedOrders(IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var list = orders.ToList();
        return customers.Where(c =>
        {
            var matches = list.Where(o => o.CustomerId == c.Id).ToList();
            return matches.Any() && matches.All(o => o.Status == "Shipped");
        }).OrderBy(c => c.Name).Select(c => c.Name).ToList();
    }

    public static bool AreAllProductPricesPositive(IEnumerable<Product> products) => products.All(p => p.UnitPrice > 0m);

    public static IReadOnlyList<string> CategoriesWhereAllProductsAreUnder(IEnumerable<Product> products, decimal maximumPrice) =>
        products.GroupBy(p => p.Category).Where(group => group.All(p => p.UnitPrice <= maximumPrice))
            .Select(group => group.Key).OrderBy(category => category).ToList();

    public static IReadOnlyList<int> OrdersWhereAllItemsMeetQuantity(
        IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems, int minimumQuantity)
    {
        var items = orderItems.ToList();
        return orders.Where(o =>
        {
            var matches = items.Where(i => i.OrderId == o.Id).ToList();
            return matches.Any() && matches.All(i => i.Quantity >= minimumQuantity);
        }).OrderBy(o => o.Id).Select(o => o.Id).ToList();
    }

    public static IReadOnlyList<string> ManagersWhoseReportsAllEarnAtLeast(IEnumerable<Employee> employees, decimal minimumSalary)
    {
        var list = employees.ToList();
        return list.Where(m =>
        {
            var reports = list.Where(e => e.ManagerId == m.Id).ToList();
            return reports.Any() && reports.All(e => e.Salary >= minimumSalary);
        }).OrderBy(m => m.Name).Select(m => m.Name).ToList();
    }

    public static IReadOnlyList<string> CustomersWhoseOrdersAreFinalized(IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var list = orders.ToList();
        return customers.Where(c =>
        {
            var matches = list.Where(o => o.CustomerId == c.Id).ToList();
            return matches.Any() && matches.All(o => o.Status is "Shipped" or "Cancelled");
        }).OrderBy(c => c.Name).Select(c => c.Name).ToList();
    }

    public static bool DoAllCustomersHaveCities(IEnumerable<Customer> customers) =>
        customers.All(c => !string.IsNullOrWhiteSpace(c.City));

    public static IReadOnlyList<string> DepartmentsWhereAllEmployeesHaveManagers(
        IEnumerable<Department> departments, IEnumerable<Employee> employees)
    {
        var list = employees.ToList();
        return departments.Where(d =>
        {
            var matches = list.Where(e => e.DeptId == d.Id).ToList();
            return matches.Any() && matches.All(e => e.ManagerId is not null);
        }).OrderBy(d => d.Name).Select(d => d.Name).ToList();
    }
}
