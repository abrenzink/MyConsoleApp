// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");

DateTime today = DateTime.Today;
DateTime targetDate = new DateTime(2026, 12, 5);

int daysRemaining = (targetDate - today).Days;

Console.WriteLine($"There are {daysRemaining} days until the next Christmas.");

