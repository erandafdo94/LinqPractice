using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class ExecutionTests
{
    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_01() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.ExpensiveProductNamesDeferred));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_02() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.ExpensiveProductNamesSnapshot));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_03() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.ProductCountSnapshot));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_04() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.CustomerNamesByCityDeferred));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_05() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.CustomerNamesByCitySnapshot));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_06() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.OrderIdsByStatusDeferred));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_07() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.OrderIdsByStatusSnapshot));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_08() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.ProductPricesDeferred));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_09() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.ProductPricesSnapshot));

    [Fact]
    [Trait("Topic", "Execution")]
    public void EXEC_10() =>
        PracticeTest.Verify(typeof(ExecutionQuestions), nameof(ExecutionQuestions.SalaryLeaderboardDeferred));
}
