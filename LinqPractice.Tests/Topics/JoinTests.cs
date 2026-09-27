using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class JoinTests
{
    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_01() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.EmployeeDepartments));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_02() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.CustomersWhoOrdered));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_03() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.ShippedInvoiceLines));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_04() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.OrdersWithCustomerNames));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_05() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.OrderItemProductDetails));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_06() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.EmployeeManagerPairs));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_07() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.CustomerOrderDates));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_08() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.ProductQuantityLines));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_09() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.DepartmentSalaryRoster));

    [Fact]
    [Trait("Topic", "Join")]
    public void JOIN_10() =>
        PracticeTest.Verify(typeof(JoinQuestions), nameof(JoinQuestions.ShippedOrderCustomerTotals));
}
