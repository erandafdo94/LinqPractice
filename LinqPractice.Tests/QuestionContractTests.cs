using System.Collections;
using System.Reflection;
using LinqPractice.Answers;
using LinqPractice.Questions;
using Xunit;

namespace LinqPractice.Tests;

public sealed class QuestionContractTests
{
    public static IEnumerable<object[]> PracticeCases()
    {
        var assembly = typeof(WhereQuestions).Assembly;
        var questionTypes = assembly.GetTypes()
            .Where(type => type.Namespace == "LinqPractice.Questions" && type.Name.EndsWith("Questions"))
            .OrderBy(type => TopicOrder(type.Name));

        foreach (var questionType in questionTypes)
        {
            var answerTypeName = $"LinqPractice.Answers.{questionType.Name[..^"Questions".Length]}Answers";
            var answerType = assembly.GetType(answerTypeName)
                ?? throw new InvalidOperationException($"Missing answer type {answerTypeName}.");

            var methods = questionType.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .OrderBy(method => method.MetadataToken)
                .ToArray();

            for (var index = 0; index < methods.Length; index++)
                yield return [$"{QuestionPrefix(questionType.Name)}-{index + 1:00}", questionType.Name, answerType.Name, methods[index].Name];
        }
    }

    [Theory]
    [MemberData(nameof(PracticeCases))]
    public void Practice_answer_matches_reference(
        string questionId,
        string questionTypeName,
        string answerTypeName,
        string methodName)
    {
        _ = questionId;
        var (questionMethod, answerMethod) = ResolveMethods(questionTypeName, answerTypeName, methodName);
        var arguments = CreateArguments(questionMethod);

        var expected = Invoke(answerMethod, arguments);
        var actual = Invoke(questionMethod, arguments);

        Assert.Equal(Describe(expected), Describe(actual));
        if (expected is IQueryable)
            Assert.IsAssignableFrom<IQueryable>(actual);
    }

    [Fact]
    public void Reference_answer_contracts_are_complete_and_executable()
    {
        var cases = PracticeCases().ToArray();
        Assert.Equal(170, cases.Length);

        foreach (var item in cases)
        {
            var (_, answerMethod) = ResolveMethods((string)item[1], (string)item[2], (string)item[3]);
            _ = Describe(Invoke(answerMethod, CreateArguments(answerMethod)));
        }
    }

    private static (MethodInfo Question, MethodInfo Answer) ResolveMethods(
        string questionTypeName,
        string answerTypeName,
        string methodName)
    {
        var assembly = typeof(WhereQuestions).Assembly;
        var questionType = assembly.GetType($"LinqPractice.Questions.{questionTypeName}")!;
        var answerType = assembly.GetType($"LinqPractice.Answers.{answerTypeName}")!;
        var questionMethod = questionType.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static)!;
        var parameterTypes = questionMethod.GetParameters().Select(parameter => parameter.ParameterType).ToArray();
        var answerMethod = answerType.GetMethod(methodName, parameterTypes)
            ?? throw new InvalidOperationException($"{answerType.Name}.{methodName} does not match the practice signature.");
        return (questionMethod, answerMethod);
    }

    private static object?[] CreateArguments(MethodInfo method) =>
        method.GetParameters().Select(parameter => CreateArgument(method, parameter)).ToArray();

    private static object CreateArgument(MethodInfo method, ParameterInfo parameter)
    {
        var type = parameter.ParameterType;
        var name = parameter.Name!;

        if (type == typeof(IEnumerable<Department>)) return PracticeData.Departments;
        if (type == typeof(IEnumerable<Employee>)) return PracticeData.Employees;
        if (type == typeof(IEnumerable<Customer>)) return PracticeData.Customers;
        if (type == typeof(IEnumerable<Product>)) return PracticeData.Products;
        if (type == typeof(IEnumerable<Order>)) return PracticeData.Orders;
        if (type == typeof(IEnumerable<OrderItem>)) return PracticeData.OrderItems;
        if (type == typeof(IQueryable<Employee>)) return PracticeData.Employees.AsQueryable();
        if (type == typeof(IQueryable<Customer>)) return PracticeData.Customers.AsQueryable();
        if (type == typeof(IQueryable<Product>)) return PracticeData.Products.AsQueryable();
        if (type == typeof(IQueryable<Order>)) return PracticeData.Orders.AsQueryable();
        if (type == typeof(IQueryable<OrderItem>)) return PracticeData.OrderItems.AsQueryable();

        if (type == typeof(decimal))
        {
            if (name.Contains("salary", StringComparison.OrdinalIgnoreCase)) return 90_000m;
            if (name == "taxRate") return 0.15m;
            if (name.Contains("maximum", StringComparison.OrdinalIgnoreCase)) return 300m;
            if (name.Contains("total", StringComparison.OrdinalIgnoreCase)) return 500m;
            return 100m;
        }

        if (type == typeof(int))
        {
            if (name is "year" or "includedYear") return 2024;
            if (name == "excludedYear") return 2025;
            if (name == "pageNumber") return 2;
            if (name == "pageIndex") return 1;
            if (name == "employeeId" || name == "customerId" || name == "departmentId" || name == "orderId") return 1;
            return 2;
        }

        if (type == typeof(string))
        {
            if (name == "status") return "Shipped";
            if (name == "category") return "Peripherals";
            if (name == "city") return "Auckland";
            if (name == "productName") return "Monitor";
            if (name == "name" && method.Name.Contains("Department", StringComparison.Ordinal)) return "Engineering";
            if (name == "name") return "Monitor";
        }

        if (type == typeof(DateOnly))
        {
            if (name == "startDate") return new DateOnly(2024, 6, 1);
            if (name == "endDate") return new DateOnly(2024, 7, 31);
            if (name == "asOfDate") return new DateOnly(2026, 1, 1);
            return new DateOnly(2024, 7, 1);
        }

        throw new InvalidOperationException($"No test value is configured for {method.Name} parameter {name}: {type}.");
    }

    private static object? Invoke(MethodInfo method, object?[] arguments)
    {
        try
        {
            return method.Invoke(null, arguments);
        }
        catch (TargetInvocationException exception) when (exception.InnerException is not null)
        {
            throw exception.InnerException;
        }
    }

    private static string Describe(object? value)
    {
        if (value is null) return "<null>";
        if (value is string text) return text;

        var type = value.GetType();
        var keyProperty = type.GetProperty("Key");
        if (keyProperty is not null && value is IEnumerable grouping)
            return $"{Describe(keyProperty.GetValue(value))}:{DescribeSequence(grouping)}";

        if (value is IDictionary dictionary)
        {
            var entries = dictionary.Keys.Cast<object>()
                .OrderBy(key => key.ToString(), StringComparer.Ordinal)
                .Select(key => $"{Describe(key)}={Describe(dictionary[key])}");
            return $"{{{string.Join("|", entries)}}}";
        }

        if (value is IEnumerable sequence)
            return DescribeSequence(sequence);

        return value.ToString() ?? type.FullName!;
    }

    private static string DescribeSequence(IEnumerable sequence) =>
        $"[{string.Join("|", sequence.Cast<object?>().Select(Describe))}]";

    private static int TopicOrder(string name) => name switch
    {
        nameof(WhereQuestions) => 1,
        nameof(SelectQuestions) => 2,
        nameof(OrderingQuestions) => 3,
        nameof(AnyQuestions) => 4,
        nameof(AllQuestions) => 5,
        nameof(ElementQuestions) => 6,
        nameof(PaginationQuestions) => 7,
        nameof(SelectManyQuestions) => 8,
        nameof(SetQuestions) => 9,
        nameof(JoinQuestions) => 10,
        nameof(GroupJoinQuestions) => 11,
        nameof(GroupByQuestions) => 12,
        nameof(AggregateQuestions) => 13,
        nameof(ConversionQuestions) => 14,
        nameof(ToDictionaryQuestions) => 15,
        nameof(ExecutionQuestions) => 16,
        nameof(QueryableQuestions) => 17,
        _ => int.MaxValue
    };

    private static string QuestionPrefix(string name) => name switch
    {
        nameof(WhereQuestions) => "WHERE",
        nameof(SelectQuestions) => "SELECT",
        nameof(OrderingQuestions) => "ORDER",
        nameof(AnyQuestions) => "ANY",
        nameof(AllQuestions) => "ALL",
        nameof(ElementQuestions) => "ELEMENT",
        nameof(PaginationQuestions) => "PAGE",
        nameof(SelectManyQuestions) => "MANY",
        nameof(SetQuestions) => "SET",
        nameof(JoinQuestions) => "JOIN",
        nameof(GroupJoinQuestions) => "GJOIN",
        nameof(GroupByQuestions) => "GROUP",
        nameof(AggregateQuestions) => "AGG",
        nameof(ConversionQuestions) => "CONVERT",
        nameof(ToDictionaryQuestions) => "DICT",
        nameof(ExecutionQuestions) => "EXEC",
        nameof(QueryableQuestions) => "QUERY",
        _ => throw new ArgumentOutOfRangeException(nameof(name), name, null)
    };
}
