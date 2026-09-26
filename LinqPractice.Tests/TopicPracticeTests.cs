using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests;

public sealed class TopicPracticeTests
{
    [Fact]
    public void Where_answers_are_correct()
    {
        Assert.Equal(["Ana", "Chen"], WhereQuestions.AucklandCustomerNames(PracticeData.Customers));
        Assert.Equal(["Keyboard", "Webcam", "Monitor"],
            WhereQuestions.ProductsPricedBetween(PracticeData.Products, 80m, 300m));
        Assert.Equal([1, 2, 4], WhereQuestions.ShippedOrderIdsInYear(PracticeData.Orders, 2024));
    }

    [Fact]
    public void Select_answers_are_correct()
    {
        Assert.Equal(["Desk", "Keyboard", "Monitor", "Mouse", "Webcam"],
            SelectQuestions.ProductCatalog(PracticeData.Products).Select(row => row.Name));
        Assert.Equal(["FRANK", "GRACE", "HANA", "IVAN", "JO", "KIM", "LENA", "MILO", "NORA"],
            SelectQuestions.UppercaseEmployeeNames(PracticeData.Employees));
        Assert.Equal([80m, 50m, 600m, 450m, 25m, 300m, 240m, 300m, 100m],
            SelectQuestions.OrderItemTotals(PracticeData.OrderItems).Select(row => row.LineTotal));
    }

    [Fact]
    public void Ordering_answers_are_correct()
    {
        Assert.Equal(["Ana", "Chen", "Dia", "Ben", "Eli"],
            OrderingQuestions.CustomersByCityThenName(PracticeData.Customers));
        Assert.Equal(["Desk", "Monitor", "Webcam", "Keyboard", "Mouse"],
            OrderingQuestions.ProductsMostExpensiveFirst(PracticeData.Products));
        Assert.Equal(["Frank", "Grace", "Hana", "Jo", "Ivan", "Kim", "Lena", "Milo", "Nora"],
            OrderingQuestions.EmployeesBySalaryThenName(PracticeData.Employees));
    }

    [Fact]
    public void Any_answers_are_correct()
    {
        Assert.True(AnyQuestions.HasPendingOrders(PracticeData.Orders));
        Assert.Equal(["Ana", "Ben", "Chen", "Dia"],
            AnyQuestions.CustomersWithOrders(PracticeData.Customers, PracticeData.Orders));
        Assert.Equal(["Webcam"],
            AnyQuestions.ProductsNeverOrdered(PracticeData.Products, PracticeData.OrderItems));
        Assert.Equal(["Engineering", "Sales"], AnyQuestions.DepartmentsWithHighEarner(
            PracticeData.Departments, PracticeData.Employees, 100_000m));
    }

    [Fact]
    public void All_answers_handle_empty_sequences()
    {
        Assert.False(AllQuestions.AreAllOrdersFinalized(PracticeData.Orders));
        Assert.Equal(["Engineering", "Sales"], AllQuestions.DepartmentsWhereEveryoneEarnsAtLeast(
            PracticeData.Departments, PracticeData.Employees, 90_000m));
        Assert.Equal(["Ana", "Chen"],
            AllQuestions.CustomersWithOnlyShippedOrders(PracticeData.Customers, PracticeData.Orders));
    }

    [Fact]
    public void Element_answers_enforce_cardinality()
    {
        Assert.Equal(1, ElementQuestions.FirstShippedOrder(PracticeData.Orders)!.Id);
        Assert.Equal("Monitor", ElementQuestions.ProductByExactName(PracticeData.Products, "Monitor")!.Name);
        Assert.Null(ElementQuestions.ProductByExactName(PracticeData.Products, "Missing"));
        Assert.Equal(6, ElementQuestions.LatestOrderOrDefault(PracticeData.Orders, 2)!.Id);
        Assert.Equal("Mouse", ElementQuestions.CheapestProduct(PracticeData.Products)!.Name);
    }

    [Fact]
    public void Pagination_answers_are_correct()
    {
        Assert.Equal(["Webcam", "Keyboard"], PaginationQuestions.ProductPage(PracticeData.Products, 2, 2));
        Assert.Equal(["Frank", "Grace", "Hana"],
            PaginationQuestions.TopHighestPaid(PracticeData.Employees, 3));
        Assert.Equal(["1,2", "3,4", "5,6"], PaginationQuestions.OrderIdBatches(PracticeData.Orders, 2));
    }

    [Fact]
    public void SelectMany_answers_are_correct()
    {
        Assert.Equal(9, SelectManyQuestions.AllOrderLines(PracticeData.Orders, PracticeData.OrderItems).Count);
        Assert.Equal(
            [("Ana", "Keyboard, Monitor, Mouse"), ("Ben", "Desk, Monitor, Mouse"),
             ("Chen", "Monitor, Mouse"), ("Dia", "Keyboard"), ("Eli", "")],
            SelectManyQuestions.ProductsByCustomer(
                PracticeData.Customers, PracticeData.Orders, PracticeData.OrderItems, PracticeData.Products));
        Assert.Equal(8, SelectManyQuestions.DepartmentEmployees(
            PracticeData.Departments, PracticeData.Employees).Count);
        Assert.Equal([("Ana", 730m), ("Ben", 400m), ("Chen", 325m), ("Dia", 0m), ("Eli", 0m)],
            SelectManyQuestions.ShippedRevenueByCustomer(
                PracticeData.Customers, PracticeData.Orders, PracticeData.OrderItems));
    }

    [Fact]
    public void Set_answers_are_correct()
    {
        Assert.Equal(["Auckland", "Christchurch", "Wellington"],
            SetQuestions.DistinctCustomerCitiesWithOrders(PracticeData.Customers, PracticeData.Orders));
        Assert.Equal(["Ben", "Dia"],
            SetQuestions.CustomersNeedingFollowUp(PracticeData.Customers, PracticeData.Orders));
        Assert.Equal(["Ana", "Ben", "Chen"], SetQuestions.CustomersWhoOrderedMonitorAndMouse(
            PracticeData.Customers, PracticeData.Orders, PracticeData.OrderItems, PracticeData.Products));
        Assert.Equal(["Desk", "Webcam"], SetQuestions.ProductsNeverShipped(
            PracticeData.Products, PracticeData.Orders, PracticeData.OrderItems));
    }

    [Fact]
    public void Join_answers_are_correct()
    {
        Assert.Equal(8, JoinQuestions.EmployeeDepartments(PracticeData.Employees, PracticeData.Departments).Count);
        Assert.Equal(["Ana", "Ben", "Chen"], JoinQuestions.CustomersWhoOrdered(
            PracticeData.Customers, PracticeData.Orders, PracticeData.OrderItems, PracticeData.Products, "Monitor"));
        var invoiceLines = JoinQuestions.ShippedInvoiceLines(
            PracticeData.Orders, PracticeData.Customers, PracticeData.OrderItems, PracticeData.Products);
        Assert.Equal(7, invoiceLines.Count);
        Assert.Equal(600m, invoiceLines.Single(row => row.OrderId == 2).LineTotal);
    }

    [Fact]
    public void GroupJoin_answers_preserve_outer_rows()
    {
        Assert.Equal([("Ana", 2), ("Ben", 2), ("Chen", 1), ("Dia", 1), ("Eli", 0)],
            GroupJoinQuestions.OrderCountByCustomer(PracticeData.Customers, PracticeData.Orders));
        Assert.Equal("Unassigned",
            GroupJoinQuestions.EmployeeDepartmentDirectory(
                PracticeData.Employees, PracticeData.Departments).Single(row => row.Employee == "Nora").Department);
        Assert.Equal(("Finance", 0, 0m),
            GroupJoinQuestions.DepartmentPayrollSummary(
                PracticeData.Departments, PracticeData.Employees).Single(row => row.Department == "Finance"));
        Assert.Equal(4,
            GroupJoinQuestions.DirectReportCountByEmployee(
                PracticeData.Employees).Single(row => row.Employee == "Frank").DirectReports);
    }

    [Fact]
    public void GroupBy_answers_are_correct()
    {
        Assert.Equal([("Auckland", 2), ("Christchurch", 1), ("Wellington", 2)],
            GroupByQuestions.CustomerCountByCity(PracticeData.Customers));
        Assert.Equal(5, GroupByQuestions.MonthlyOrderStatusSummary(PracticeData.Orders).Count);
        Assert.Equal(("Peripherals", 3, 75m, 120m),
            GroupByQuestions.CategoryPriceSummary(PracticeData.Products).Single(row => row.Category == "Peripherals"));
        Assert.Equal("Webcam",
            GroupByQuestions.HighestPricedProductByCategory(PracticeData.Products).Single(row => row.Category == "Peripherals").Product);
    }

    [Fact]
    public void Aggregate_answers_are_correct()
    {
        Assert.Equal([130m, 600m, 450m, 325m, 240m, 400m],
            AggregateQuestions.OrderTotals(PracticeData.Orders, PracticeData.OrderItems).Select(row => row.Total));
        Assert.Equal([("Ana", 600m), ("Ben", 450m), ("Chen", 325m), ("Dia", 240m)],
            AggregateQuestions.LargestOrderByCustomer(
                PracticeData.Customers, PracticeData.Orders, PracticeData.OrderItems));
        Assert.Equal(357.5m, AggregateQuestions.AverageOrderValue(PracticeData.Orders, PracticeData.OrderItems));
        Assert.Equal([(1, 130m), (2, 730m), (4, 1055m), (6, 1455m)],
            AggregateQuestions.RunningShippedRevenue(PracticeData.Orders, PracticeData.OrderItems));
    }

    [Fact]
    public void Conversion_answers_are_correct()
    {
        var statusLookup = ConversionQuestions.OrderIdsByStatus(PracticeData.Orders);
        Assert.Equal([1, 2, 4, 6], statusLookup["Shipped"]);
        Assert.Empty(statusLookup["Unknown"]);

        var customerLookup = ConversionQuestions.OrdersByCustomerId(PracticeData.Orders);
        Assert.Equal([1, 2], customerLookup[1].Select(order => order.Id));
        Assert.Empty(customerLookup[999]);

        var categoryLookup = ConversionQuestions.ProductNamesByCategory(PracticeData.Products);
        Assert.Equal(["Keyboard", "Mouse", "Webcam"], categoryLookup["Peripherals"]);
    }

    [Fact]
    public void ToDictionary_answers_are_correct()
    {
        Assert.Equal("Monitor", ToDictionaryQuestions.ProductNamesById(PracticeData.Products)[2]);
        Assert.Equal("Shipped", ToDictionaryQuestions.LatestOrderStatusByCustomer(
            PracticeData.Customers, PracticeData.Orders)["Ben"]);
        Assert.Equal(0, ToDictionaryQuestions.EmployeeCountByDepartment(
            PracticeData.Departments, PracticeData.Employees)["Finance"]);
        Assert.Equal(600m, ToDictionaryQuestions.OrderTotalsById(
            PracticeData.Orders, PracticeData.OrderItems)[2]);
    }

    [Fact]
    public void Execution_answers_have_the_requested_timing()
    {
        var deferredSource = PracticeData.Products.ToList();
        var deferred = ExecutionQuestions.ExpensiveProductNamesDeferred(deferredSource, 100m);
        deferredSource.Add(new Product(99, "Projector", "Displays", 800m));
        Assert.Contains("Projector", deferred);

        var snapshotSource = PracticeData.Products.ToList();
        var snapshot = ExecutionQuestions.ExpensiveProductNamesSnapshot(snapshotSource, 100m);
        snapshotSource.Add(new Product(99, "Projector", "Displays", 800m));
        Assert.DoesNotContain("Projector", snapshot);
        Assert.Equal(3, ExecutionQuestions.ProductCountSnapshot(PracticeData.Products, "Peripherals"));
    }

    [Fact]
    public void Queryable_answers_do_not_enumerate_during_composition()
    {
        var source = new EnumerationTrackingEnumerable<Order>(PracticeData.Orders);
        var queryable = source.AsQueryable();

        var shipped = QueryableQuestions.ShippedOrdersFrom(queryable, new DateOnly(2024, 7, 1));
        var customerOrders = QueryableQuestions.OrdersForCustomer(queryable, 1);
        var page = QueryableQuestions.OrderPage(queryable, 1, 2);

        Assert.Equal(0, source.EnumerationCount);
        Assert.Equal([4, 6], shipped.Select(order => order.Id));
        Assert.Equal([2, 1], customerOrders.Select(order => order.Id));
        Assert.Equal([3, 4], page.Select(order => order.Id));
    }
}

internal sealed class EnumerationTrackingEnumerable<T>(IEnumerable<T> source) : IEnumerable<T>
{
    public int EnumerationCount { get; private set; }

    public IEnumerator<T> GetEnumerator()
    {
        EnumerationCount++;
        return source.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}
