using System.Collections;
using System.Reflection;
using Xunit;

namespace LinqPractice.Tests;

internal static class PracticeTest
{
    public static void Verify(Type questionType, string methodName)
    {
        var topicName = questionType.Name[..^"Questions".Length];
        var answerType = questionType.Assembly.GetType($"LinqPractice.Answers.{topicName}Answers")
            ?? throw new InvalidOperationException($"Missing reference answers for {topicName}.");

        var questionMethod = questionType.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static)
            ?? throw new InvalidOperationException($"Missing practice method {questionType.Name}.{methodName}.");
        var parameterTypes = questionMethod.GetParameters().Select(parameter => parameter.ParameterType).ToArray();
        var answerMethod = answerType.GetMethod(methodName, parameterTypes)
            ?? throw new InvalidOperationException($"The reference answer for {methodName} has a different signature.");
        var arguments = questionMethod.GetParameters()
            .Select(parameter => CreateArgument(questionMethod, parameter))
            .ToArray();

        var expected = Invoke(answerMethod, arguments);
        var actual = Invoke(questionMethod, arguments);

        Assert.Equal(Describe(expected), Describe(actual));
        if (expected is IQueryable)
            Assert.IsAssignableFrom<IQueryable>(actual);
    }

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
            if (name is "employeeId" or "customerId" or "departmentId" or "orderId") return 1;
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

        throw new InvalidOperationException(
            $"No test value is configured for {method.Name} parameter {name}: {type}.");
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
}
