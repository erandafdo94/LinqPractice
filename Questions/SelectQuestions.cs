namespace LinqPractice.Questions;

public static class SelectQuestions
{
    // Write your LINQ answers below.
    // SELECT-01 — Build a lightweight product catalogue
    // Difficulty: Simple
    // The UI does not need the complete Product object. Convert each product into a tuple
    // containing its Name, Category, and UnitPrice, then order the rows by product name.
    public static IReadOnlyList<(string Name, string Category, decimal Price)> ProductCatalog(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // SELECT-02 — Format employee names
    // Difficulty: Simple
    // Convert every employee name to uppercase using culture-independent casing. Return only
    // those formatted names and sort them alphabetically.
    public static IReadOnlyList<string> UppercaseEmployeeNames(IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // SELECT-03 — Calculate invoice line totals
    // Difficulty: Simple
    // For every order item, calculate Quantity × UnitPrice. Return tuples containing the
    // OrderItemId and calculated LineTotal, ordered by OrderItemId.
    public static IReadOnlyList<(int OrderItemId, decimal LineTotal)> OrderItemTotals(
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // SELECT-04 — Customer display labels
    // Difficulty: Medium
    // Create one label per customer in the form "Name — City". Return the labels ordered by the
    // customer's name, not by the completed label.
    public static IReadOnlyList<string> CustomerLabels(IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // SELECT-05 — Monthly employee salaries
    // Difficulty: Medium
    // Project each employee into (Name, MonthlySalary), using annual Salary ÷ 12. Order by name
    // and keep decimal precision rather than rounding.
    public static IReadOnlyList<(string Name, decimal MonthlySalary)> EmployeeMonthlySalaries(
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // SELECT-06 — Lightweight order summaries
    // Difficulty: Medium
    // Convert each order into (Id, Status, OrderDate). Sort by OrderDate and then ID; return no
    // other Order fields.
    public static IReadOnlyList<(int Id, string Status, DateOnly OrderDate)> OrderSummaries(
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // SELECT-07 — Prices after tax
    // Difficulty: Medium
    // For every product, calculate UnitPrice × (1 + `taxRate`) and return (Name, PriceWithTax).
    // Order by product name and do not round the result.
    public static IReadOnlyList<(string Name, decimal PriceWithTax)> ProductPricesWithTax(
        IEnumerable<Product> products, decimal taxRate) =>
        throw new NotImplementedException();

    // SELECT-08 — Order-item quantity summaries
    // Difficulty: Hard
    // Project order items into (OrderId, ProductId, Quantity), ordered by OrderId and then the
    // original OrderItem.Id to keep repeated products deterministic.
    public static IReadOnlyList<(int OrderId, int ProductId, int Quantity)> OrderItemSummaries(
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // SELECT-09 — Department selector options
    // Difficulty: Hard
    // Convert each department into (Value, Text), where Value is the ID converted to a string and
    // Text is the department name. Sort options alphabetically by Text.
    public static IReadOnlyList<(string Value, string Text)> DepartmentOptions(
        IEnumerable<Department> departments) =>
        throw new NotImplementedException();

    // SELECT-10 — Customer membership duration
    // Difficulty: Hard
    // For each customer, calculate the number of complete years between SignupDate and `asOfDate`.
    // Return (Name, CompleteYears) alphabetically; dates before signup should produce zero.
    public static IReadOnlyList<(string Name, int CompleteYears)> CustomerMembershipYears(
        IEnumerable<Customer> customers, DateOnly asOfDate) =>
        throw new NotImplementedException();
}
