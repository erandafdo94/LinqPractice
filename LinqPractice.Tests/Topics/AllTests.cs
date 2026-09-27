using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests.Topics;

public sealed class AllTests
{
    [Fact]
    [Trait("Topic", "All")]
    public void ALL_01() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.AreAllOrdersFinalized));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_02() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.DepartmentsWhereEveryoneEarnsAtLeast));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_03() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.CustomersWithOnlyShippedOrders));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_04() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.AreAllProductPricesPositive));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_05() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.CategoriesWhereAllProductsAreUnder));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_06() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.OrdersWhereAllItemsMeetQuantity));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_07() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.ManagersWhoseReportsAllEarnAtLeast));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_08() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.CustomersWhoseOrdersAreFinalized));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_09() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.DoAllCustomersHaveCities));

    [Fact]
    [Trait("Topic", "All")]
    public void ALL_10() =>
        PracticeTest.Verify(typeof(AllQuestions), nameof(AllQuestions.DepartmentsWhereAllEmployeesHaveManagers));
}
