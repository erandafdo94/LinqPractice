namespace LinqPractice.Answers;

public static class AnyAnswers
{
    public static bool HasPendingOrders(IEnumerable<Order> orders) => orders.Any(o => o.Status == "Pending");

    public static IReadOnlyList<string> CustomersWithOrders(IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var orderList = orders.ToList();
        return customers.Where(c => orderList.Any(o => o.CustomerId == c.Id))
            .OrderBy(c => c.Name).Select(c => c.Name).ToList();
    }

    public static IReadOnlyList<string> ProductsNeverOrdered(IEnumerable<Product> products, IEnumerable<OrderItem> orderItems)
    {
        var items = orderItems.ToList();
        return products.Where(p => !items.Any(i => i.ProductId == p.Id))
            .OrderBy(p => p.Name).Select(p => p.Name).ToList();
    }

    public static IReadOnlyList<string> DepartmentsWithHighEarner(
        IEnumerable<Department> departments, IEnumerable<Employee> employees, decimal minimumSalary)
    {
        var employeeList = employees.ToList();
        return departments.Where(d => employeeList.Any(e => e.DeptId == d.Id && e.Salary > minimumSalary))
            .OrderBy(d => d.Name).Select(d => d.Name).ToList();
    }

    public static IReadOnlyList<string> CustomersWithPendingOrders(IEnumerable<Customer> customers, IEnumerable<Order> orders)
    {
        var orderList = orders.ToList();
        return customers.Where(c => orderList.Any(o => o.CustomerId == c.Id && o.Status == "Pending"))
            .OrderBy(c => c.Name).Select(c => c.Name).ToList();
    }

    public static bool HasOrderAboveTotal(IEnumerable<Order> orders, IEnumerable<OrderItem> orderItems, decimal minimumTotal)
    {
        var items = orderItems.ToList();
        return orders.Any(o => items.Where(i => i.OrderId == o.Id).Sum(i => i.Quantity * i.UnitPrice) > minimumTotal);
    }

    public static IReadOnlyList<string> ProductsOrderedInBulk(
        IEnumerable<Product> products, IEnumerable<OrderItem> orderItems, int minimumQuantity)
    {
        var items = orderItems.ToList();
        return products.Where(p => items.Any(i => i.ProductId == p.Id && i.Quantity >= minimumQuantity))
            .OrderBy(p => p.Name).Select(p => p.Name).ToList();
    }

    public static IReadOnlyList<string> EmployeesWhoManageAnyone(IEnumerable<Employee> employees)
    {
        var list = employees.ToList();
        return list.Where(m => list.Any(e => e.ManagerId == m.Id)).OrderBy(m => m.Name).Select(m => m.Name).ToList();
    }

    public static IReadOnlyList<string> CategoriesWithAffordableProduct(IEnumerable<Product> products, decimal maximumPrice) =>
        products.Where(p => p.UnitPrice <= maximumPrice).Select(p => p.Category)
            .Distinct().OrderBy(category => category).ToList();

    public static bool HasDuplicateProductNames(IEnumerable<Product> products) =>
        products.GroupBy(p => p.Name, StringComparer.Ordinal).Any(group => group.Count() > 1);
}
