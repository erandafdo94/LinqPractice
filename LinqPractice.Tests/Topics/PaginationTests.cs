using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class PaginationTests
{
    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_01() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.ProductPage));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_02() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.TopHighestPaid));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_03() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.OrderIdBatches));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_04() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.CustomerPage));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_05() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.OrdersAfterFirst));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_06() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.ThreeCheapestProducts));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_07() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.EmployeeSalaryPage));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_08() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.MostRecentOrders));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_09() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.EmployeeNameBatches));

    [Fact]
    [Trait("Topic", "Pagination")]
    public void PAGE_10() =>
        PracticeTest.Verify(typeof(PaginationQuestions), nameof(PaginationQuestions.OrderItemWindow));
}
