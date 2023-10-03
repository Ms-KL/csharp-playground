

/*

    Code project 3 - Write code that processes the contents of a string array

    https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements


    PLANNING

    1) INPUT
        
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

    2) DECLARE VARIABLES

        int periodLocaion = 0; // hold holdation of the . within a string

    3) LOOPS

        outer:   
            foreach or for              processes myString array
            myString.IndexOf(".")       get location of first . character
                                        if no . value = -1

        inner:
            do-while or while           process myString 
            Console.WriteLine()         each element of array
                                        do not display the period character

            Remove(), Substring(), TrimStart()
                                        process string information


    4) OUTPUT

        I like pizza
        I like roast chicken
        I like salad
        I like all three of the menu choices

    5) REFERENCES:

        TrimStart()
        https://learn.microsoft.com/en-us/dotnet/api/system.string.trimstart?view=net-7.0


    Q&A:



*/

string[] myStrings = new string[2] { 
    "I like pizza. I like roast chicken. I like salad", 
    "I like all three of the menu choices" 
};

int stringsCount = myStrings.Length;

string myString = ""; // instead of foreach elm in list
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i]; // instead of foreach elm in list

    periodLocation = myString.IndexOf(".");

    string mySentence; // for elm fragment upto period

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        // deletes all values from . onwards
        //https://learn.microsoft.com/en-us/dotnet/api/system.string.remove?view=net-7.0
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        // used to iterate again and check for the next period
        //https://learn.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-7.0
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        // the space after the period and before the next fragment starts
        //https://learn.microsoft.com/en-us/dotnet/api/system.string.trimstart?view=net-7.0
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        //https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
        periodLocation = myString.IndexOf(".");

        // write the fragment to the console
        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim(); // trim whitespace for non-period conditional sentences
    Console.WriteLine(mySentence);
}



