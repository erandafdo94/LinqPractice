namespace LinqPractice.Questions;

public static class WhereQuestions
{
    // PRACTICE WORKFLOW
    // 1. Read one question and replace its NotImplementedException with your LINQ answer.
    // 2. Run that question only: dotnet test --filter "FullyQualifiedName~.WHERE_01"
    // 3. Change 01 to the question number you are solving.
    // INPUTS: The exact lists are in PracticeData.cs and are passed into each method below.
    // WHERE-01 — Customers in one city
    // Difficulty: Simple
    // The sales team needs a mailing list for Auckland. From `customers`, keep only people
    // whose City is "Auckland", return their names, and sort the names alphabetically.
    public static IReadOnlyList<string> AucklandCustomerNames(IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // WHERE-02 — Products within a budget
    // Difficulty: Simple
    // A shopper provides a minimum and maximum budget. From `products`, return the names of
    // products whose price is inside that range, including both limits. Sort by price from
    // lowest to highest, then by name when two products have the same price.
    public static IReadOnlyList<string> ProductsPricedBetween(
        IEnumerable<Product> products,
        decimal minimum,
        decimal maximum) =>
        throw new NotImplementedException();

    // WHERE-03 — Shipped orders for a year
    // Difficulty: Simple
    // From `orders`, find orders that were shipped during the supplied calendar year.
    // Return only their IDs, ordered by OrderDate and then by ID for deterministic results.
    public static IReadOnlyList<int> ShippedOrderIdsInYear(IEnumerable<Order> orders, int year) =>
        throw new NotImplementedException();

    // WHERE-04 — Employees above a salary floor
    // Difficulty: Medium
    // Keep employees earning at least `minimumSalary`. Return their names ordered by salary
    // descending and then alphabetically when salaries match.
    public static IReadOnlyList<string> EmployeesEarningAtLeast(
        IEnumerable<Employee> employees, decimal minimumSalary) =>
        throw new NotImplementedException();

    // WHERE-05 — Recent customer sign-ups
    // Difficulty: Medium
    // Return names of customers whose SignupDate is on or after `fromDate`. Sort by signup date
    // and then by name so the oldest qualifying sign-up appears first.
    public static IReadOnlyList<string> CustomersSignedUpFrom(
        IEnumerable<Customer> customers, DateOnly fromDate) =>
        throw new NotImplementedException();

    // WHERE-06 — Orders matching status and date
    // Difficulty: Medium
    // Find orders with the exact `status` placed on or after `fromDate`. Return their IDs in
    // chronological order, using ID as the tie-breaker.
    public static IReadOnlyList<int> OrdersWithStatusFrom(
        IEnumerable<Order> orders, string status, DateOnly fromDate) =>
        throw new NotImplementedException();

    // WHERE-07 — Affordable products in one category
    // Difficulty: Medium
    // Within the exact `category`, find products priced at or below `maximumPrice`. Return names
    // ordered by price and then name.
    public static IReadOnlyList<string> ProductsInCategoryUnder(
        IEnumerable<Product> products, string category, decimal maximumPrice) =>
        throw new NotImplementedException();

    // WHERE-08 — Employees without departments
    // Difficulty: Hard
    // Find employees whose DeptId is null. Return only their names in alphabetical order; do not
    // treat an unknown non-null department ID as unassigned for this question.
    public static IReadOnlyList<string> UnassignedEmployeeNames(IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // WHERE-09 — Unusually large order lines
    // Difficulty: Hard
    // Keep order items whose Quantity is at least `minimumQuantity`. Return their IDs ordered by
    // quantity descending and then ID ascending.
    public static IReadOnlyList<int> LargeOrderItemIds(
        IEnumerable<OrderItem> orderItems, int minimumQuantity) =>
        throw new NotImplementedException();

    // WHERE-10 — Orders inside an inclusive date window
    // Difficulty: Hard
    // Return IDs for orders dated between `startDate` and `endDate`, including both boundaries.
    // Sort chronologically and then by ID. An inverted date range should naturally return none.
    public static IReadOnlyList<int> OrdersInDateRange(
        IEnumerable<Order> orders, DateOnly startDate, DateOnly endDate) =>
        throw new NotImplementedException();
}
