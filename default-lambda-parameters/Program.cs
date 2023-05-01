// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, human!");

var  sum = (int x = 0, int y = 0) => x + y;
Console.WriteLine(sum()); // Output: 0
Console.WriteLine(sum(1)); // Output: 1
Console.WriteLine(sum(1, 2)); // Output: 3


var greet = (string name = "World", int times = 1) =>
{
    string greeting = $"Hello, {name}!";
    if (times > 1)
    {
        greeting += $" ({times} times)";
    }
    return greeting;
};
Console.WriteLine(greet()); // Output: Hello, World!
Console.WriteLine(greet("Alice")); // Output: Hello, Alice!
Console.WriteLine(greet("Bob", 3)); // Output: Hello, Bob! (3 times)

Console.WriteLine("End. Click enter to exit");
Console.ReadLine();
