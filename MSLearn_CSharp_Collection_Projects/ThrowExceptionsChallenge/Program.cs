
string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues); // pass in argument
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}


static void Workflow1(string[][] userEnteredValues) // parameter for flexibilty
{

    // string[][] userEnteredValues = new string[][]
    // {
    //             new string[] { "1", "2", "3"},
    //             new string[] { "1", "two", "3"},
    //             new string[] { "0", "1", "2"}
    // };

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.\n");
        }
        catch (Exception ex)
        {
            if (ex.StackTrace.Contains("Process1"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("'Process1' encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message);
                }
                else if (ex is DivideByZeroException)    
                {
                    Console.WriteLine("'Process1' encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message);
                    throw;    
                }    
                else
                {
                    Console.WriteLine("'Process1' encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message);

                } 
            }
        }
    }                
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);
            
            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("Invalid data. User input values must be valid integers.\n");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("Invalid data. User input values must be non-zero values.\n");
            throw unexpectedDivideByZeroException;
        }
    }
}
