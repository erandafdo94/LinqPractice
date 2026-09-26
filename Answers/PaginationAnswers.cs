namespace LinqPractice.Answers;

public static class PaginationAnswers
{
    public static IReadOnlyList<string> ProductPage(int pageNumber, int pageSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(pageNumber, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(pageSize, 1);

        return PracticeData.Products
            .OrderByDescending(product => product.UnitPrice)
            .ThenBy(product => product.Name)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(product => product.Name)
            .ToList();
    }

    public static IReadOnlyList<string> TopHighestPaid(int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(count);

        return PracticeData.Employees
            .OrderByDescending(employee => employee.Salary)
            .ThenBy(employee => employee.Name)
            .Take(count)
            .Select(employee => employee.Name)
            .ToList();
    }

    public static IReadOnlyList<string> OrderIdBatches(int batchSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(batchSize, 1);

        return PracticeData.Orders
            .OrderBy(order => order.Id)
            .Select(order => order.Id)
            .Chunk(batchSize)
            .Select(batch => string.Join(",", batch))
            .ToList();
    }
}
