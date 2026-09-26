namespace LinqPractice;

public sealed record Department(int Id, string Name);
public sealed record Employee(int Id, string Name, int? DeptId, decimal Salary, int? ManagerId);
public sealed record Customer(int Id, string Name, string City, DateOnly SignupDate);
public sealed record Product(int Id, string Name, string Category, decimal UnitPrice);
public sealed record Order(int Id, int CustomerId, DateOnly OrderDate, string Status);
public sealed record OrderItem(int Id, int OrderId, int ProductId, int Quantity, decimal UnitPrice);

public static class PracticeData
{
    private static DateOnly Date(string value) => DateOnly.Parse(value);

    public static readonly List<Department> Departments =
    [
        new(1, "Engineering"), new(2, "Sales"), new(3, "Support"),
        new(4, "Finance")
    ];

    public static readonly List<Employee> Employees =
    [
        new(1, "Frank", 1, 150000m, null),
        new(2, "Grace", 1, 120000m, 1),
        new(3, "Hana", 1, 120000m, 1),
        new(4, "Ivan", 1,  95000m, 1),
        new(5, "Jo",    2, 110000m, 1),
        new(6, "Kim",   2,  90000m, 5),
        new(7, "Lena",  3,  85000m, 5),
        new(8, "Milo",  3,  85000m, 5),
        new(9, "Nora",  null, 70000m, null)
    ];

    public static readonly List<Customer> Customers =
    [
        new(1, "Ana",  "Auckland",     Date("2024-01-15")),
        new(2, "Ben",  "Wellington",   Date("2024-02-03")),
        new(3, "Chen", "Auckland",     Date("2024-03-20")),
        new(4, "Dia",  "Christchurch", Date("2024-05-11")),
        new(5, "Eli",  "Wellington",   Date("2025-01-08"))
    ];

    public static readonly List<Product> Products =
    [
        new(1, "Keyboard", "Peripherals",  80.00m),
        new(2, "Monitor",  "Displays",    300.00m),
        new(3, "Mouse",    "Peripherals",  25.00m),
        new(4, "Desk",     "Furniture",   450.00m),
        new(5, "Webcam",   "Peripherals", 120.00m)
    ];

    public static readonly List<Order> Orders =
    [
        new(1, 1, Date("2024-06-01"), "Shipped"),
        new(2, 1, Date("2024-06-15"), "Shipped"),
        new(3, 2, Date("2024-07-02"), "Pending"),
        new(4, 3, Date("2024-07-19"), "Shipped"),
        new(5, 4, Date("2024-08-05"), "Cancelled"),
        new(6, 2, Date("2025-02-10"), "Shipped")
    ];

    public static readonly List<OrderItem> OrderItems =
    [
        new(1, 1, 1, 1,  80.00m),
        new(2, 1, 3, 2,  25.00m),
        new(3, 2, 2, 2, 300.00m),
        new(4, 3, 4, 1, 450.00m),
        new(5, 4, 3, 1,  25.00m),
        new(6, 4, 2, 1, 300.00m),
        new(7, 5, 1, 3,  80.00m),
        new(8, 6, 2, 1, 300.00m),
        new(9, 6, 3, 4,  25.00m)
    ];
}
