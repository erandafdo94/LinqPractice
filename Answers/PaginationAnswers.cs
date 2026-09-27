namespace LinqPractice.Answers;

public static class PaginationAnswers
{
    public static IReadOnlyList<string> ProductPage(IEnumerable<Product> products, int pageNumber, int pageSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(pageNumber, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(pageSize, 1);
        return products.OrderByDescending(p => p.UnitPrice).ThenBy(p => p.Name)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize).Select(p => p.Name).ToList();
    }

    public static IReadOnlyList<string> TopHighestPaid(IEnumerable<Employee> employees, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        return employees.OrderByDescending(e => e.Salary).ThenBy(e => e.Name).Take(count).Select(e => e.Name).ToList();
    }

    public static IReadOnlyList<string> OrderIdBatches(IEnumerable<Order> orders, int batchSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(batchSize, 1);
        return orders.OrderBy(o => o.Id).Select(o => o.Id).Chunk(batchSize)
            .Select(batch => string.Join(",", batch)).ToList();
    }

    public static IReadOnlyList<string> CustomerPage(IEnumerable<Customer> customers, int pageNumber, int pageSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(pageNumber, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(pageSize, 1);
        return customers.OrderBy(c => c.Name).Skip((pageNumber - 1) * pageSize)
            .Take(pageSize).Select(c => c.Name).ToList();
    }

    public static IReadOnlyList<int> OrdersAfterFirst(IEnumerable<Order> orders, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        return orders.OrderBy(o => o.OrderDate).ThenBy(o => o.Id).Skip(count).Select(o => o.Id).ToList();
    }

    public static IReadOnlyList<string> ThreeCheapestProducts(IEnumerable<Product> products) =>
        products.OrderBy(p => p.UnitPrice).ThenBy(p => p.Name).Take(3).Select(p => p.Name).ToList();

    public static IReadOnlyList<string> EmployeeSalaryPage(IEnumerable<Employee> employees, int pageIndex, int pageSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(pageIndex);
        ArgumentOutOfRangeException.ThrowIfLessThan(pageSize, 1);
        return employees.OrderByDescending(e => e.Salary).ThenBy(e => e.Name)
            .Skip(pageIndex * pageSize).Take(pageSize).Select(e => e.Name).ToList();
    }

    public static IReadOnlyList<int> MostRecentOrders(IEnumerable<Order> orders, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        return orders.OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.Id)
            .Take(count).Select(o => o.Id).ToList();
    }

    public static IReadOnlyList<string[]> EmployeeNameBatches(IEnumerable<Employee> employees, int batchSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(batchSize, 1);
        return employees.OrderBy(e => e.Name).Select(e => e.Name).Chunk(batchSize).ToList();
    }

    public static IReadOnlyList<int> OrderItemWindow(IEnumerable<OrderItem> orderItems, int offset, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(offset);
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        return orderItems.OrderBy(i => i.Id).Skip(offset).Take(count).Select(i => i.Id).ToList();
    }
}
