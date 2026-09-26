var topics = new TopicInfo[]
{
    new(1, "where", "Where", "WHERE", 3),
    new(2, "select", "Select", "SELECT", 3),
    new(3, "ordering", "Ordering", "ORDER", 3),
    new(4, "any", "Any", "ANY", 4),
    new(5, "all", "All", "ALL", 3),
    new(6, "elements", "Element operators", "ELEMENT", 4),
    new(7, "pagination", "Skip, Take, and Chunk", "PAGE", 3),
    new(8, "select-many", "SelectMany", "MANY", 4),
    new(9, "sets", "Set operators", "SET", 4),
    new(10, "join", "Join", "JOIN", 3),
    new(11, "group-join", "GroupJoin", "GJOIN", 4),
    new(12, "group-by", "GroupBy", "GROUP", 4),
    new(13, "aggregates", "Aggregates", "AGG", 4),
    new(14, "to-lookup", "ToLookup", "CONVERT", 3),
    new(15, "to-dictionary", "ToDictionary", "DICT", 4),
    new(16, "execution", "Deferred vs immediate execution", "EXEC", 3),
    new(17, "iqueryable", "IQueryable", "QUERY", 3)
};

if (args.Length == 0 || args[0] is "help" or "-h" or "--help")
{
    PrintHelp();
    return;
}

if (args[0].Equals("topics", StringComparison.OrdinalIgnoreCase) ||
    args is ["list"])
{
    foreach (var topic in topics)
        Console.WriteLine($"{topic.Number,2}. {topic.Slug,-20} {topic.Title} ({topic.QuestionCount} questions)");
    return;
}

if (args[0].Equals("list", StringComparison.OrdinalIgnoreCase) ||
    args[0].Equals("show", StringComparison.OrdinalIgnoreCase))
{
    if (args.Length < 2)
    {
        Console.Error.WriteLine("Supply a topic, for example: dotnet run -- list any");
        Environment.ExitCode = 1;
        return;
    }

    var topic = topics.FirstOrDefault(item =>
        item.Slug.Equals(args[1], StringComparison.OrdinalIgnoreCase) || item.Number.ToString() == args[1]);

    if (topic is null)
    {
        Console.Error.WriteLine($"Unknown topic '{args[1]}'. Run 'dotnet run -- topics'.");
        Environment.ExitCode = 1;
        return;
    }

    var questionFile = $"Questions/{topic.TypeName}Questions.cs";
    var answerFile = $"Answers/{topic.TypeName}Answers.cs";
    Console.WriteLine($"{topic.Number:00}. {topic.Title}");
    Console.WriteLine($"Practice: {questionFile}");
    Console.WriteLine($"Solutions: {answerFile}");

    if (args[0].Equals("show", StringComparison.OrdinalIgnoreCase) && args.Length >= 3)
    {
        if (!int.TryParse(args[2], out var number) || number < 1 || number > topic.QuestionCount)
        {
            Console.Error.WriteLine($"Choose a question from 1 to {topic.QuestionCount}.");
            Environment.ExitCode = 1;
            return;
        }

        Console.WriteLine($"Question: {topic.Prefix}-{number:00}");
    }

    return;
}

Console.Error.WriteLine("Unknown command. Run 'dotnet run' for help.");
Environment.ExitCode = 1;

static void PrintHelp()
{
    Console.WriteLine("LINQ interview practice");
    Console.WriteLine("  dotnet run -- topics");
    Console.WriteLine("  dotnet run -- list any");
    Console.WriteLine("  dotnet run -- show any 2");
    Console.WriteLine("  dotnet test --filter FullyQualifiedName~Any_answers");
}

internal sealed record TopicInfo(
    int Number,
    string Slug,
    string Title,
    string Prefix,
    int QuestionCount)
{
    public string TypeName => Slug switch
    {
        "select-many" => "SelectMany",
        "group-join" => "GroupJoin",
        "group-by" => "GroupBy",
        "to-lookup" => "Conversion",
        "to-dictionary" => "ToDictionary",
        "iqueryable" => "Queryable",
        "sets" => "Set",
        "aggregates" => "Aggregate",
        "elements" => "Element",
        _ => string.Concat(Slug.Split('-').Select(part => char.ToUpperInvariant(part[0]) + part[1..]))
    };
}
