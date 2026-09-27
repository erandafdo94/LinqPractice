using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class SelectManyTests
{
    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_01() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.AllOrderLines));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_02() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.ProductsByCustomer));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_03() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.DepartmentEmployees));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_04() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.ShippedRevenueByCustomer));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_05() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.OrderLinesWithProducts));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_06() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.ManagerReportPairs));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_07() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.CustomerOrderIds));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_08() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.CategoryProductPairs));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_09() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.OrderLineRevenue));

    [Fact]
    [Trait("Topic", "SelectMany")]
    public void MANY_10() =>
        PracticeTest.Verify(typeof(SelectManyQuestions), nameof(SelectManyQuestions.ProductNamesOrderedWithStatus));
}
