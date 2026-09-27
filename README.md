# LINQ Interview Practice

This repository is organized by LINQ topic. Every topic has exactly 10 interview exercises. You write your answer directly in the method under each question, then run that question's test to check it.

```text
Questions/AnyQuestions.cs             -> questions and methods where you write your code
LinqPractice.Tests/Topics/AnyTests.cs -> one independently runnable test per question
Answers/AnyAnswers.cs                 -> optional reference solutions for after your attempt
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

# Test exactly one answer
dotnet test --filter "FullyQualifiedName~.ANY_01"

# Test all 10 Any answers
dotnet test --filter "Topic=Any"
```

Example workflow:

1. Open `Questions/AnyQuestions.cs` and read `ANY-01`.
2. The input collections are parameters on the method immediately below the question.
3. Replace `throw new NotImplementedException()` with your LINQ query, without opening the answer folder.
4. Run `dotnet test --filter "FullyQualifiedName~.ANY_01"` to test only that question.
5. A green test means the returned result is correct. If it fails, read the expected/actual output and revise your method.
6. Optionally compare your query with the matching method in `Answers/AnyAnswers.cs` after solving it.
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

There are 170 questions in total. Each topic follows the same progression:

- Questions 01–03: **Simple** fundamentals.
- Questions 04–07: **Medium** combinations and realistic reporting tasks.
- Questions 08–10: **Hard** edge cases, multi-source queries, or execution behavior.

The overall path moves from basic in-memory LINQ to the areas interviewers commonly probe for deeper understanding: cardinality, empty sequences, left joins, grouped calculations, dictionary key uniqueness, deferred execution, and query-provider boundaries.

## Folder structure

```text
LinqPractice/
├── Questions/              # prompts + editable methods; one file per topic
├── Answers/                # one matching solution file per topic
├── LinqPractice.Tests/
│   └── Topics/             # matching test file for every topic
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

Every untouched practice method starts with `throw new NotImplementedException()`. Replace only the method you are practicing, then run its exact test by converting the question ID's hyphen to an underscore:

```bash
# ANY-01
dotnet test --filter "FullyQualifiedName~.ANY_01"

# GROUP-04
dotnet test --filter "FullyQualifiedName~.GROUP_04"

# All questions in the GroupBy topic
dotnet test --filter "Topic=GroupBy"
```

Running `dotnet test` without a filter runs all 170 exercises, so unfinished methods will fail. Use the single-question command while practicing and the topic command after completing all 10 methods in a file.
