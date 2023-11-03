// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

// Calculate the sum of the even numbers between the bounds
averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

// Display the value returned by AverageOfEvenNumbers in the console
Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
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