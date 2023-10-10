/*
    GOAL: Combine String Array Values as Strings and Integers

    1. Split up data depending on type
    2. Concatenate or Add Data accordingly

    TASKS:

    1. Create loop that will:
        - iterate through each string value in array: values

    2. Add the following conditions:
        - if value = string, concatenate to output message
        - if value = numeric, add to total

    3. result = output:
        Message: ABCDEF
        Total: 68.3


    VARIABLES:

    - string[] values = { "12.3", "45", "ABC", "11", "DEF" };
    - decimal total = 0m;
    - string message = "";

*/


// instantiate string array
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// initialise variables
decimal total = 0m;
string message = "";
// string result = "";

// get length of array
int valuesLength = values.Length;

// loop until length of array is complete
for (int i = 0; i < valuesLength; i++)
{
    decimal amount = 0m;
    string value = values[i];


    if (decimal.TryParse(value, out amount))
    {
        total += amount;

    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");
