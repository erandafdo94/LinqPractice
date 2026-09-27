using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class OrderingTests
{
    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_01() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.CustomersByCityThenName));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_02() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.ProductsMostExpensiveFirst));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_03() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.EmployeesBySalaryThenName));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_04() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.OrdersNewestFirst));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_05() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.DepartmentsByNameLength));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_06() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.CustomersNewestSignupFirst));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_07() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.OrderItemsByQuantityThenPrice));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_08() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.ProductsByCategoryThenPrice));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_09() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.ManagersBeforeReports));

    [Fact]
    [Trait("Topic", "Ordering")]
    public void ORDER_10() =>
        PracticeTest.Verify(typeof(OrderingQuestions), nameof(OrderingQuestions.OrdersByStatusThenDate));
}
