using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class QueryableTests
{
    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_01() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.ShippedOrdersFrom));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_02() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.OrdersForCustomer));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_03() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.OrderPage));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_04() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.ProductsInCategory));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_05() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.ProductsAtMostPrice));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_06() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.CustomersInCity));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_07() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.EmployeesInDepartment));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_08() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.OrdersWithStatus));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_09() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.ItemsForOrder));

    [Fact]
    [Trait("Topic", "Queryable")]
    public void QUERY_10() =>
        PracticeTest.Verify(typeof(QueryableQuestions), nameof(QueryableQuestions.ProductPage));
}
