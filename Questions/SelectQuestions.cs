namespace LinqPractice.Questions;

public static class SelectQuestions
{
    // Write your LINQ answers below.
    // SELECT-01 — Build a lightweight product catalogue
    // The UI does not need the complete Product object. Convert each product into a tuple
    // containing its Name, Category, and UnitPrice, then order the rows by product name.
    public static IReadOnlyList<(string Name, string Category, decimal Price)> ProductCatalog(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // SELECT-02 — Format employee names
    // Convert every employee name to uppercase using culture-independent casing. Return only
    // those formatted names and sort them alphabetically.
    public static IReadOnlyList<string> UppercaseEmployeeNames(IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // SELECT-03 — Calculate invoice line totals
    // For every order item, calculate Quantity × UnitPrice. Return tuples containing the
    // OrderItemId and calculated LineTotal, ordered by OrderItemId.
    public static IReadOnlyList<(int OrderItemId, decimal LineTotal)> OrderItemTotals(
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();
}
