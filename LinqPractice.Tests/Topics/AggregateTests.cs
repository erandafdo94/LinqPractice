using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class AggregateTests
{
    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_01() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.OrderTotals));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_02() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.LargestOrderByCustomer));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_03() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.AverageOrderValue));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_04() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.RunningShippedRevenue));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_05() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.TotalOrderItemRevenue));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_06() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.AverageProductPrice));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_07() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.HighestEmployeeSalary));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_08() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.LowestOrderTotal));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_09() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.TotalUnitsByProduct));

    [Fact]
    [Trait("Topic", "Aggregate")]
    public void AGG_10() =>
        PracticeTest.Verify(typeof(AggregateQuestions), nameof(AggregateQuestions.OrdersAboveOverallAverage));
}
