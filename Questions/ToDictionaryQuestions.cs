namespace LinqPractice.Questions;

public static class ToDictionaryQuestions
{
    // Write your LINQ answers below.
    // DICT-01 — Product names keyed by ID
    // Convert `products` into a dictionary whose key is Product.Id and value is Product.Name.
    // ToDictionary should naturally throw if the input contains duplicate product IDs.
    public static IReadOnlyDictionary<int, string> ProductNamesById(IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // DICT-02 — Latest order status by customer
    // Build a dictionary from customer Name to the Status of their newest order. Resolve the
    // multiple orders per customer before calling ToDictionary. Omit customers with no orders.
    public static IReadOnlyDictionary<string, string> LatestOrderStatusByCustomer(
        IEnumerable<Customer> customers,
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // DICT-03 — Department headcount dictionary
    // Build a dictionary from every department Name to the number of matching employees.
    // Empty departments must remain in the dictionary with a value of zero.
    public static IReadOnlyDictionary<string, int> EmployeeCountByDepartment(
        IEnumerable<Department> departments,
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // DICT-04 — Order totals keyed by ID
    // Build a dictionary where Order.Id is the key and the value is the sum of Quantity ×
    // UnitPrice for that order's items. Orders without items should map to 0m.
    public static IReadOnlyDictionary<int, decimal> OrderTotalsById(
        IEnumerable<Order> orders,
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();
}
