/*
    https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/6-challenge-2
    Your application will be using a combination of permission and level to apply/evaluate the business rules in this challenge scenario. The full list of conditions for business rules is specified in the next step. Your completed solution must use permission and level.
    Tip
    To sufficiently test all of the combinations for permission and level that are described in the business rules below, you will need to assign additional values to these variables and run the application multiple times.

    -------

    Implement Business Rules:
        - use Contains() helper method to:
            - determine if permission string Contains() a permission value specified by business rules
                - eg: 
                    - permission.Contains("Admin") will return TRUE if 
                        string permission = "Admin|Manager";

    RULES:
        If the user is an Admin with a level greater than 55, output the message:
        Output
        Welcome, Super Admin user.

        If the user is an Admin with a level less than or equal to 55, output the message:
        Output
        Welcome, Admin user.

        If the user is a Manager with a level 20 or greater, output the message:
        Output
        Contact an Admin for access.

        If the user is a Manager with a level less than 20, output the message:
        Output
        You do not have sufficient privileges.

        If the user is not an Admin or a Manager, output the message:
        Output
        You do not have sufficient privileges.
*/

string permission = "Pie";
int level = 10;

if (permission.Contains("Admin"))
    {
        Console.WriteLine(level > 55 ? "Welcome, Super Admin user" : "Welcome, Admin user.");
    }
else if (permission.Contains("Manager"))
    {
        Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
    }
else
    Console.WriteLine("You do not have sufficient privileges.");
