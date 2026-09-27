using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class ToDictionaryTests
{
    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_01() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.ProductNamesById));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_02() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.LatestOrderStatusByCustomer));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_03() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.EmployeeCountByDepartment));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_04() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.OrderTotalsById));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_05() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.CustomerCitiesById));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_06() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.DepartmentPayrollByName));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_07() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.LatestOrderIdByCustomer));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_08() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.ProductPricesByName));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_09() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.ShippedRevenueByCustomer));

    [Fact]
    [Trait("Topic", "ToDictionary")]
    public void DICT_10() =>
        PracticeTest.Verify(typeof(ToDictionaryQuestions), nameof(ToDictionaryQuestions.OrderCountByStatus));
}
