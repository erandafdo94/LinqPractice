# LINQ Interview Practice

This repository is organized by LINQ topic. Every topic has one question file with 3–4 interview exercises, editable practice methods in that same file, and one matching answer file with complete reference solutions.

```text
Questions/AnyQuestions.cs   -> prompts plus methods where you write your code
Answers/AnyAnswers.cs       -> reference implementations
```

The exercises share the small commerce and employee dataset in `PracticeData.cs`, so you can focus on the query rather than setup code.

## Start here

```bash
# See the complete learning path
dotnet run -- topics

# Show the practice and solution files for one topic
dotnet run -- list any

# Locate one numbered question
dotnet run -- show any 2

# Confirm the project compiles
dotnet build
```

Example workflow:

1. Open `Questions/AnyQuestions.cs` and read `ANY-01`.
2. The input collections are parameters on the method immediately below the question.
3. Replace `throw new NotImplementedException()` with your LINQ query, without opening the answer folder.
4. Run `dotnet test --filter "FullyQualifiedName=LinqPractice.Tests.TopicPracticeTests.Any_answers_are_correct"`.
5. Compare your query with the matching method in `Answers/AnyAnswers.cs`.
6. Explain the time complexity and how the query would translate to SQL.

## Learning path

| # | Topic | What to know for interviews |
|---:|---|---|
| 1 | `Where` | predicates, ranges, combining conditions |
| 2 | `Select` | projection, calculated fields, result shaping |
| 3 | Ordering | ascending/descending order, `ThenBy`, deterministic ties |
| 4 | `Any` | existence, correlated `Any`, `NOT EXISTS` |
| 5 | `All` | universal conditions and the empty-sequence trap |
| 6 | Element operators | `FirstOrDefault`, `SingleOrDefault`, `MinBy`, cardinality |
| 7 | Pagination | `Skip`, `Take`, top-N, `Chunk` |
| 8 | `SelectMany` | flattening one-to-many data |
| 9 | Set operators | `Distinct`, `Union`, `Intersect`, `ExceptBy` |
| 10 | `Join` | inner joins and multi-table projections |
| 11 | `GroupJoin` | left joins, parent/child counts, outer aggregates |
| 12 | `GroupBy` | simple/composite keys and per-group selection |
| 13 | Aggregates | `Sum`, `Average`, `Max`, stateful `Aggregate` |
| 14 | `ToLookup` | one-to-many lookups and missing keys |
| 15 | `ToDictionary` | unique keys, duplicate-key handling, calculated values |
| 16 | Execution | deferred execution, materialization, snapshots |
| 17 | `IQueryable` | provider-side composition and avoiding early enumeration |

There are 59 questions in total. The order deliberately moves from basic in-memory LINQ to the areas interviewers commonly probe for deeper understanding: cardinality, empty sequences, left joins, grouped calculations, dictionary key uniqueness, deferred execution, and query-provider boundaries.

## Folder structure

```text
LinqPractice/
├── Questions/              # prompts + editable methods; one file per topic
├── Answers/                # one matching solution file per topic
├── LinqPractice.Tests/     # tests for your practice methods, grouped by topic
├── PracticeData.cs         # shared records and sample data
├── Program.cs              # topic/question browser
└── README.md               # learning path and commands
```

## Interview habits to practice

- State whether the query uses deferred or immediate execution.
- Add deterministic ordering whenever output order matters.
- Know how `Any`, `All`, `FirstOrDefault`, and `SingleOrDefault` behave on empty input.
- Guard `All` when an empty child collection must not qualify.
- Resolve duplicate keys before `ToDictionary`.
- Keep database-bound work as `IQueryable`; avoid early `ToList` or `AsEnumerable`.
- Prefer readable query composition over squeezing everything into one expression.

Every practice method starts with `throw new NotImplementedException()`. The project builds immediately, but its practice tests fail until you implement the relevant methods. Run one topic at a time using the focused test command, then compare your work with the matching file under `Answers`.
