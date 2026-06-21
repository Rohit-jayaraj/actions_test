using git_actions_test;

Console.WriteLine("=== Welcome to the Git Actions practice Console App ===");

var calc = new Calculator();
int a = 10;
int b = 5;

Console.WriteLine($"{a} + {b} = {calc.Add(a, b)}");
Console.WriteLine($"{a} - {b} = {calc.Subtract(a, b)}");
Console.WriteLine($"{a} * {b} = {calc.Multiply(a, b)}");
Console.WriteLine($"{a} / {b} = {calc.Divide(a, b)}");
