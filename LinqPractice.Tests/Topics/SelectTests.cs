using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class SelectTests
{
    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_01() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.ProductCatalog));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_02() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.UppercaseEmployeeNames));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_03() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.OrderItemTotals));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_04() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.CustomerLabels));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_05() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.EmployeeMonthlySalaries));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_06() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.OrderSummaries));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_07() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.ProductPricesWithTax));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_08() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.OrderItemSummaries));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_09() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.DepartmentOptions));

    [Fact]
    [Trait("Topic", "Select")]
    public void SELECT_10() =>
        PracticeTest.Verify(typeof(SelectQuestions), nameof(SelectQuestions.CustomerMembershipYears));
}
