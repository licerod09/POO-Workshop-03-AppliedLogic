using Shared;

var answer = "s";
var options = new List<string> { "s", "n" };

// Keep drawing rhombuses until the user decides to stop
while (answer == "s")
{
    int n = ConsoleExtension.GetInt("Enter the size of the rhombus: ");

    // Draw the upper half of the rhombus
    for (int i = 1; i <= n; i += 2)
    {
        int spaces = (n - i) / 2;
        for (int j = 0; j < spaces; j++)
            Console.Write(" ");
        for (int j = 0; j < i; j++)
        {
            if (j == 0 || j == i - 1)
                Console.Write("#");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }

    //Draw the lower half of the rhombus
    for (int i = n - 2; i >= 1; i -= 2)
    {
        int spaces = (n - i) / 2;
        for (int j = 0; j < spaces; j++)
            Console.Write(" ");
        for (int j = 0; j < i; j++)
        {
            if (j == 0 || j == i - 1)
                Console.Write("#");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
    answer = ConsoleExtension.GetValidOptions("Do you want to enter another rhombus? (s/n): ",
        options
        ) ?? "n";
}
Console.WriteLine("Thanks for using the Rhombus program. Goodbye!");