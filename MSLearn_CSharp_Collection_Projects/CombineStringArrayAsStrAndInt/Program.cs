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
string messag = "";