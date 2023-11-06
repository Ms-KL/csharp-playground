// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

// check to see if user enters exit
bool exit = false;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the value returned by AverageOfEvenNumbers in the console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    }
    catch (ArgumentOutOfRangeException ex) 
    // create catch method using exception in throw portion of AverageOfEvenNumbers Method
    {
        // explain issue to user, obtain new upper bound
        Console.WriteLine("An error has occured.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.WriteLine($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {   
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }
} while (exit == false);

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    if (lowerBound >= upperBound)
    {
        /*
        Initialize a new instance of the ArgumentOutOfRangeException class with 
            the name of the input parameter that causes the exception and a specified error message.
        */
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
        
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}


/*

Notice that the application performs the following tasks:

a. The top-level statements use Console.ReadLine() statements to obtain values for lowerBound and upperBound.

b. The top-level statements pass lowerBound and upperBound as arguments when calling the AverageOfEvenNumbers method.

c. The AverageOfEvenNumbers method performs the following tasks:
    Declares local variables used in calculations.
    Uses a for loop to sum the even numbers between lowerBound and upperBound. The sum is stored in sum.
    Counts how many numbers are included in the sum. The count is stored in count.
    Stores the average of the summed numbers in a variable named average. The value of average is returned.

d. The top-level statements print the value returned by AverageOfEvenNumbers to the console and then pauses execution.

*/