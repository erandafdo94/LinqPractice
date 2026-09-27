using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class GroupByTests
{
    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_01() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.CustomerCountByCity));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_02() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.MonthlyOrderStatusSummary));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_03() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.CategoryPriceSummary));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_04() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.HighestPricedProductByCategory));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_05() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.SalarySummaryByDepartmentId));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_06() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.OrderCountByCustomerId));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_07() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.ProductCountByPriceBand));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_08() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.CustomerSignupsByYear));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_09() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.UnitsByProductId));

    [Fact]
    [Trait("Topic", "GroupBy")]
    public void GROUP_10() =>
        PracticeTest.Verify(typeof(GroupByQuestions), nameof(GroupByQuestions.EmployeesSharingSalary));
}
