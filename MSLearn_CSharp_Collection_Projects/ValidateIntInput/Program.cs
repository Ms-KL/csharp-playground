
/*
    Code project 1 - write code that validates integer input

    https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements

    Here are the conditions that your first coding project must implement:

        - Your solution must include either a do-while or while iteration.

        - Before the iteration block: 
            - your solution must use a:             
            Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

        - Inside the iteration block:

            - Your solution must use a Console.ReadLine() statement to obtain input from the user.
            - Your solution must ensure that the input is a valid representation of an integer.
            - If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
            - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

        - Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

    
    PLANNING:

        1) BEFORE Loop:
            - Console.WriteLine() to prompt user for:
                - int value between 5-10
            ** notes for loop: 
                * convert string input to int
                * conditionals to validate input

        2) Loop:
            - Console.Readline() to obtain user input
            - check for and convert to int from string
            - conditional: between 5-10 or throw error using Console.WriteLine()

        3) After Loop:
            - Console.WriteLine() for validation message to user

    OUTPUT:

        Enter an integer value between 5 and 10
        two
        Sorry, you entered an invalid number, please try again
        2
        You entered 2. Please enter a number between 5 and 10.
        7
        Your input value (7) has been accepted.

*/



string? readResult; // null string ok
int numericValue = 0;
bool validNumber = false;
bool validEntry = false;
Console.WriteLine("Enter an integer value between 5 and 10"); // user prompt

do
{
    // execute this immediately and then additional times while condition is met
    readResult = Console.ReadLine(); // .ReadLine() = user input

    if (readResult != null) // if user enters something
    {
        validEntry = int.TryParse(readResult, out numericValue);

        if (validEntry)
        {
            if ((numericValue > 5) && (numericValue < 10)) 
            {
                // Console.WriteLine(numericValue);
                validNumber = true;
            }
            else
            {
                Console.WriteLine($"You entered {numericValue}. Please Enter a valid Number");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again.");     
        }
    }
} while (validNumber == false);


Console.WriteLine($"Your input value ({numericValue}) has been accepted.");


/// ------------------------- SOLUTION

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();