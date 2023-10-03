
/*
    Code project 2 - write code that validates string input

    https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements

    1) BEFORE LOOP:

        - Console.WriteLine()   prompt user for one of 3 role names
        
    2) LOOP:

        - Console.ReadLine()    user input
        - Validation            input matches one of 3 role names
        - Trim()                ignore leading and trailing space
        - ToLower()             transform input to lower case
        - Console.WriteLine()   prompt user for valid entry

    3) AFTER LOOP:

        - Console.WriteLine()   inform user input is accepted

    4) OUTPUT:

        Enter your role name (Administrator, Manager, or User)
        Admin
        The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
        Administrator
        Your input value (Administrator) has been accepted.

*/


string? readResult; // null string ok
bool validRole = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();

    if (readResult != null) // if user enters something
    {
        readResult = readResult.Trim();
        string cleanedResult = readResult.ToLower();
        
        if ((cleanedResult == "administrator") || (cleanedResult == "manager") || (cleanedResult == "user"))
        {
            validRole = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }

} while (validRole == false);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");


/// ------------------------- SOLUTION


// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();