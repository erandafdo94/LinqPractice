using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class GroupJoinTests
{
    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_01() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.OrderCountByCustomer));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_02() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.EmployeeDepartmentDirectory));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_03() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.DepartmentPayrollSummary));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_04() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.DirectReportCountByEmployee));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_05() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.OrderItemCountByProduct));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_06() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.LatestOrderIdByCustomer));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_07() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.HighestSalaryByDepartment));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_08() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.ItemCountByOrder));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_09() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.TotalQuantityByProduct));

    [Fact]
    [Trait("Topic", "GroupJoin")]
    public void GJOIN_10() =>
        PracticeTest.Verify(typeof(GroupJoinQuestions), nameof(GroupJoinQuestions.DirectReportNamesByEmployee));
}
