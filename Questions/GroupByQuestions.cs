namespace LinqPractice.Questions;

public static class GroupByQuestions
{
    // Write your LINQ answers below.

    // GROUP-01 — Customer count by city
    // Difficulty: Simple
    // The reporting team wants one row per city. Group `customers` by City, return each city
    // with the number of customers who live there, and sort the rows alphabetically by city.
    public static IReadOnlyList<(string City, int CustomerCount)> CustomerCountByCity(
        IEnumerable<Customer> customers) =>
        customers
            .GroupBy(customer => customer.City)
            .OrderBy(group => group.Key)
            .Select(group => (group.Key, group.Count())).ToList();
    
    // GROUP-02 — Monthly order-status summary
    // Difficulty: Simple
    // Group orders using a composite key of OrderDate.Year, OrderDate.Month, and Status. Return
    // the key values plus Count, ordered chronologically and then alphabetically by status.
    public static IReadOnlyList<(int Year, int Month, string Status, int Count)> MonthlyOrderStatusSummary(
        IEnumerable<Order> orders) => orders
        .GroupBy(order => new { order.OrderDate.Year, order.OrderDate.Month, order.Status })
        .OrderBy(group => group.Key.Year).ThenBy(group => group.Key.Month).ThenBy(group => group.Key.Status)
        .Select(group => (group.Key.Year, group.Key.Month, group.Key.Status, group.Count())).ToList();

    // GROUP-03 — Category price statistics
    // Difficulty: Simple
    // Produce one row per product category containing ProductCount, AveragePrice, and HighestPrice.
    // Sort categories alphabetically. All calculations should use UnitPrice.
    public static IReadOnlyList<(string Category, int ProductCount, decimal AveragePrice, decimal HighestPrice)> CategoryPriceSummary(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // GROUP-04 — Most expensive product per category
    // Difficulty: Medium
    // Group products by Category and select the product with the highest UnitPrice from each
    // group. Return Category, Product name, and Price, ordered alphabetically by category.
    public static IReadOnlyList<(string Category, string Product, decimal Price)> HighestPricedProductByCategory(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // GROUP-05 — Salary summary by department ID
    // Difficulty: Medium
    // Group assigned employees by DeptId and return department ID, employee count, and average
    // salary. Ignore unassigned employees and order rows by department ID.
    public static IReadOnlyList<(int DepartmentId, int EmployeeCount, decimal AverageSalary)> SalarySummaryByDepartmentId(
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();

    // GROUP-06 — Order count by customer ID
    // Difficulty: Medium
    // Group orders by CustomerId and return each ID with its order count. Only customers present
    // in the order data appear; sort by customer ID.
    public static IReadOnlyList<(int CustomerId, int OrderCount)> OrderCountByCustomerId(
        IEnumerable<Order> orders) =>
        throw new NotImplementedException();

    // GROUP-07 — Products grouped into price bands
    // Difficulty: Medium
    // Classify UnitPrice below 100 as "Budget", below 300 as "Standard", and all others as
    // "Premium". Return each band and product count in Budget, Standard, Premium order.
    public static IReadOnlyList<(string Band, int ProductCount)> ProductCountByPriceBand(
        IEnumerable<Product> products) =>
        throw new NotImplementedException();

    // GROUP-08 — Customer sign-ups by year
    // Difficulty: Hard
    // Group customers by SignupDate.Year and return Year with CustomerCount, ordered by year.
    public static IReadOnlyList<(int Year, int CustomerCount)> CustomerSignupsByYear(
        IEnumerable<Customer> customers) =>
        throw new NotImplementedException();

    // GROUP-09 — Units ordered by product ID
    // Difficulty: Hard
    // Group order items by ProductId and sum Quantity. Return ProductId and TotalUnits ordered by
    // product ID; products without items do not appear.
    public static IReadOnlyList<(int ProductId, int TotalUnits)> UnitsByProductId(
        IEnumerable<OrderItem> orderItems) =>
        throw new NotImplementedException();

    // GROUP-10 — Employees sharing a salary
    // Difficulty: Hard
    // Group employees by Salary, keep only groups containing more than one person, and return the
    // salary plus alphabetical comma-separated names. Sort by salary descending.
    public static IReadOnlyList<(decimal Salary, string Employees)> EmployeesSharingSalary(
        IEnumerable<Employee> employees) =>
        throw new NotImplementedException();
}
