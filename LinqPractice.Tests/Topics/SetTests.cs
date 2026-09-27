using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class SetTests
{
    [Fact]
    [Trait("Topic", "Set")]
    public void SET_01() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.DistinctCustomerCitiesWithOrders));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_02() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.CustomersNeedingFollowUp));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_03() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.CustomersWhoOrderedMonitorAndMouse));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_04() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.ProductsNeverShipped));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_05() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.CustomerAndEmployeeNames));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_06() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.FirstCustomerNameByCity));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_07() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.UniqueCustomerAndEmployeeNames));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_08() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.CustomersWithoutOrders));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_09() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.CustomersWithShippedAndPendingOrders));

    [Fact]
    [Trait("Topic", "Set")]
    public void SET_10() =>
        PracticeTest.Verify(typeof(SetQuestions), nameof(SetQuestions.ProductsOrderedInYearButNotAnother));
}
