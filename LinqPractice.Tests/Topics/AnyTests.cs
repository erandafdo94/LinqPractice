using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class AnyTests
{
    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_01() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.HasPendingOrders));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_02() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.CustomersWithOrders));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_03() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.ProductsNeverOrdered));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_04() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.DepartmentsWithHighEarner));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_05() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.CustomersWithPendingOrders));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_06() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.HasOrderAboveTotal));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_07() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.ProductsOrderedInBulk));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_08() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.EmployeesWhoManageAnyone));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_09() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.CategoriesWithAffordableProduct));

    [Fact]
    [Trait("Topic", "Any")]
    public void ANY_10() =>
        PracticeTest.Verify(typeof(AnyQuestions), nameof(AnyQuestions.HasDuplicateProductNames));
}
