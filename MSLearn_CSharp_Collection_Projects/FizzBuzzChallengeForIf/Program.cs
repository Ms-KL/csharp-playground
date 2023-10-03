

// https://learn.microsoft.com/en-gb/training/modules/csharp-for/3-challenge

/*
    Output values from 1 to 100, 
        one number per line, 
        inside the code block of an iteration statement.
    When the current value is divisible by 3, 
        print the term Fizz next to the number.
    When the current value is divisible by 5, 
        print the term Buzz next to the number.
    When the current value is divisible by both 3 and 5, 
        print the term FizzBuzz next to the number.
*/

// int[] fizzBuzz;


for (int i = 1; i < 101; i++)
{
    Console.Write(i);

    bool fizz = (i % 3) == 0;
    bool buzz = (i % 5) == 0;

    if (fizz || buzz)
    {
        Console.Write(" - ");
    }
    if (fizz)
    {
        Console.Write("Fizz");
    }
    if (buzz)
    {
        Console.Write("Buzz");
    }

    Console.Write("\n");

}

// ---- alt:
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}