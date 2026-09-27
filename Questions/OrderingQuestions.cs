namespace LinqPractice.Questions;

public static class OrderingQuestions
{
    // PRACTICE WORKFLOW
    // 1. Read one question and replace its NotImplementedException with your LINQ answer.
    // 2. Run that question only: dotnet test --filter "FullyQualifiedName~.ORDER_01"
    // 3. Change 01 to the question number you are solving.
    // INPUTS: The exact lists are in PracticeData.cs and are passed into each method below.
    // ORDER-01 — Sort a customer directory
    // Difficulty: Simple
    // Return customer names grouped naturally by location: sort customers by City first and
    // then by Name within each city. The result should contain names only.
    public static IReadOnlyList<string> CustomersByCityThenName(IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // ORDER-02 — Most expensive products first
    // Difficulty: Simple
    // Return product names ordered from highest UnitPrice to lowest. If prices are equal,
    // sort those products alphabetically so the result is deterministic.
    public static IReadOnlyList<string> ProductsMostExpensiveFirst(IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // ORDER-03 — Salary ranking
    // Difficulty: Simple
    // Rank employees from highest salary to lowest and return their names. Employees with the
    // same salary must be ordered alphabetically; do not return the salary itself.
    public static IReadOnlyList<string> EmployeesBySalaryThenName(IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // ORDER-04 — Newest orders first
    // Difficulty: Medium
    // Return order IDs sorted by OrderDate descending. When orders share a date, place the larger
    // ID first so the newest-looking record remains deterministic.
    public static IReadOnlyList<int> OrdersNewestFirst(IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // ORDER-05 — Departments by name length
    // Difficulty: Medium
    // Return department names from shortest to longest. Departments with equal-length names must
    // be sorted alphabetically.
    public static IReadOnlyList<string> DepartmentsByNameLength(
        IEnumerable<Department> departments) =>
        throw new NotImplementedException();

    // ORDER-06 — Most recent customer sign-ups
    // Difficulty: Medium
    // Return customer names ordered by SignupDate descending and then name ascending. Do not
    // return the date itself.
    public static IReadOnlyList<string> CustomersNewestSignupFirst(
        IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // ORDER-07 — Largest quantities first
    // Difficulty: Medium
    // Return order-item IDs sorted by Quantity descending, then UnitPrice descending, and finally
    // ID ascending to resolve all remaining ties.
    public static IReadOnlyList<int> OrderItemsByQuantityThenPrice(
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // ORDER-08 — Product catalogue by category and price
    // Difficulty: Hard
    // Return product names grouped alphabetically by Category. Inside each category, order by
    // UnitPrice ascending and then by Name.
    public static IReadOnlyList<string> ProductsByCategoryThenPrice(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // ORDER-09 — Managers before reports
    // Difficulty: Hard
    // Return employee names with employees who have no ManagerId first. Within the manager and
    // report sections, sort by salary descending and then name.
    public static IReadOnlyList<string> ManagersBeforeReports(IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // ORDER-10 — Status work queue
    // Difficulty: Hard
    // Return order IDs sorted by Status alphabetically, then OrderDate ascending, then ID. The
    // query must provide a total deterministic ordering.
    public static IReadOnlyList<int> OrdersByStatusThenDate(IEnumerable<Order> orders) =>
        throw new NotImplementedException();
}
