using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class WhereTests
{
    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_01() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.AucklandCustomerNames));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_02() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.ProductsPricedBetween));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_03() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.ShippedOrderIdsInYear));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_04() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.EmployeesEarningAtLeast));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_05() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.CustomersSignedUpFrom));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_06() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.OrdersWithStatusFrom));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_07() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.ProductsInCategoryUnder));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_08() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.UnassignedEmployeeNames));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_09() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.LargeOrderItemIds));

    [Fact]
    [Trait("Topic", "Where")]
    public void WHERE_10() =>
        PracticeTest.Verify(typeof(WhereQuestions), nameof(WhereQuestions.OrdersInDateRange));
}
