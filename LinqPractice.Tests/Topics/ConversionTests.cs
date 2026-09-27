using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class ConversionTests
{
    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_01() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.OrderIdsByStatus));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_02() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.OrdersByCustomerId));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_03() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.ProductNamesByCategory));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_04() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.EmployeesByDepartmentId));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_05() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.OrderItemsByOrderId));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_06() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.CustomerNamesByCity));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_07() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.ProductNamesByFirstLetter));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_08() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.OrderIdsByYear));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_09() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.EmployeeNamesByManagerId));

    [Fact]
    [Trait("Topic", "Conversion")]
    public void CONVERT_10() =>
        PracticeTest.Verify(typeof(ConversionQuestions), nameof(ConversionQuestions.ProductIdsByPriceBand));
}
