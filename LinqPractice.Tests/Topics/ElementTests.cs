using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class ElementTests
{
    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_01() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.FirstShippedOrder));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_02() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.ProductByExactName));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_03() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.LatestOrderOrDefault));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_04() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.CheapestProduct));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_05() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.FirstCustomerInCity));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_06() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.DepartmentByExactName));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_07() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.MostExpensiveProduct));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_08() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.LastOrderInYear));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_09() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.SecondCheapestProduct));

    [Fact]
    [Trait("Topic", "Element")]
    public void ELEMENT_10() =>
        PracticeTest.Verify(typeof(ElementQuestions), nameof(ElementQuestions.EmployeeById));
}
