﻿/*
This application manages transactions at a store check-out line. The
check-out line has a cash register, and the register has a cash till
that is prepared with a number of bills each morning. The till includes
bills of four denominations: $1, $5, $10, and $20. The till is used
to provide the customer with change during the transaction. The item 
cost is a randomly generated number between 2 and 49. The customer 
offers payment based on an algorithm that determines a number of bills
in each denomination. 

Each day, the cash till is loaded at the start of the day. As transactions
occur, the cash till is managed in a method named MakeChange (customer 
payments go in and the change returned to the customer comes out). A 
separate "safety check" calculation that's used to verify the amount of
money in the till is performed in the "main program". This safety check
is used to ensure that logic in the MakeChange method is working as 
expected.
*/

// ____________________________________________________________________


// ---------START OF TOP-LEVEL STATEMENT---------

string? readResult = null;
bool useTestData = false; // false = use randomly generated test data

Console.Clear();

int[] cashTill = new int[] { 0, 0, 0, 0 };
int registerCheckTillTotal = 0;

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
int testCounter = 0;

LoadTillEachMorning(registerDailyStartingCash, cashTill);

registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// display the number of bills of each denomination currently in the till
LogTillStatus(cashTill);

// display a message showing the amount of cash in the till
Console.WriteLine(TillAmountSummary(cashTill));

// display the expected registerDailyStartingCash total
Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

var valueGenerator = new Random((int)DateTime.Now.Ticks);

// UPDATE TO 40
//int transactions = 10;
int transactions = 40;

if (useTestData)
{
    transactions = testData.Length;
}

// -- ITERATE THROUGH TRANSACTIONS
while (transactions > 0)
{
    transactions -= 1;

    // UPDATE RANDOMISED VALUES TO 50
    // This cost range is a better match for items that customers will be purchasing.
    //int itemCost = valueGenerator.Next(2, 20);
    int itemCost = valueGenerator.Next(2, 50);    

    if (useTestData)
    {
        itemCost = testData[testCounter];
        testCounter += 1;
    }

    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

    // display messages describing the current transaction
    Console.WriteLine($"Customer is making a ${itemCost} purchase");
    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

    // ------ START OF: ENCLOSE METHOD IN TRY STATEMENT TO VERIFY TILL BALANCE ------

    try
    {    
        // STRING TO VOID
        // MakeChange manages the transaction and updates the till 
        // string transactionMessage = MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

        // MakeChange manages the transaction and updates the till 
        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

        Console.WriteLine($"Transaction successfully completed.");
        registerCheckTillTotal += itemCost;

    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"Could not complete transaction: {e.Message}");

        /*
            The InvalidOperationException exception object thrown in MakeChange will be caught, but other exception types won't. 
            
            Since you're not prepared to handle other exception types, it's important to let them be caught lower in the call stack. 
            
            If you become aware that other exception types are expected within MakeChange, you can add additional catch clauses.
        */
    }

    // ------ END OF: ENCLOSE METHOD IN TRY STATEMENT TO VERIFY TILL BALANCE ------

    // NOT REQUIRED - MESSAGE DISPLAYED IN TRY/CATCH BLOCK INSTEAD

    // // Backup Calculation - each transaction adds current "itemCost" to the till
    // if (transactionMessage == "transaction succeeded")
    // {
    //     Console.WriteLine($"Transaction successfully completed.");
    //     registerCheckTillTotal += itemCost;
    // }
    // else
    // {
    //     Console.WriteLine($"Transaction unsuccessful: {transactionMessage}");
    // }

    Console.WriteLine(TillAmountSummary(cashTill));
    Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");
    Console.WriteLine();
}

Console.WriteLine("Press the Enter key to exit");
do
{
    readResult = Console.ReadLine(); // REQUIRES DEBUG CONFIG CONSOLE

} while (readResult == null);

// ---------END OF TOP-LEVEL STATEMENT---------


static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
{
    cashTill[0] = registerDailyStartingCash[0, 1];
    cashTill[1] = registerDailyStartingCash[1, 1];
    cashTill[2] = registerDailyStartingCash[2, 1];
    cashTill[3] = registerDailyStartingCash[3, 1];
}

// STRING TO VOID
// static string MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
    // STRING TO VOID
    //string transactionMessage = "";

    cashTill[3] += twenties;
    cashTill[2] += tens;
    cashTill[1] += fives;
    cashTill[0] += ones;

    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
    int changeNeeded = amountPaid - cost;

    // if (changeNeeded < 0)
    //     transactionMessage = "Not enough money provided.";
    
    /*
        PRESENTS ISSUE:
        
        If changeNeeded is less than zero, 
            the customer has not provided enough money to cover the purchase price of the item they're buying. The purchase price and the money provided by the customer are parameters of the MakeChange method. 
        
        The method is unable to complete the transaction when 
            the customer doesn't provide enough money. 
        
        In other words, the operation fails.

    */

    if (changeNeeded < 0)
    throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");
    // InvalidOperationException: exception should only be thrown when the operating conditions of a method don't support the successful completion of a particular method call. In this case the operating conditions are established by the parameters supplied to the method.

    Console.WriteLine("Cashier Returns:");

    while ((changeNeeded > 19) && (cashTill[3] > 0))
    {
        cashTill[3]--;
        changeNeeded -= 20;
        Console.WriteLine("\t A twenty");
    }

    while ((changeNeeded > 9) && (cashTill[2] > 0))
    {
        cashTill[2]--;
        changeNeeded -= 10;
        Console.WriteLine("\t A ten");
    }

    while ((changeNeeded > 4) && (cashTill[1] > 0))
    {
        cashTill[1]--; // change from $10 index to $5 index
        changeNeeded -= 5;
        Console.WriteLine("\t A five");
    }

    while ((changeNeeded > 0) && (cashTill[0] > 0))
    {
        cashTill[0]--;
        changeNeeded--;
        Console.WriteLine("\t A one");
    }

    // if (changeNeeded > 0)
    //     transactionMessage = "Can't make change. Do you have anything smaller?";
    
    /*
        PRESENTS ISSUE:

        If changeNeeded is greater than zero after the while loops that prepare the change, 
            then the till has run out of bills that can be used to make change. 
        
        The method is unable to complete the transaction when the till lacks the bills required to make change. 
        
        In other words, the operation fails.

    */

    if (changeNeeded > 0)
        throw new InvalidOperationException("InvalidOperationException: The till is unable to make the correct change.");

    // STRING TO VOID
    // if (transactionMessage == "")
    //     transactionMessage = "transaction succeeded";

    // return transactionMessage;
}

static void LogTillStatus(int[] cashTill)
{
    Console.WriteLine("The till currently has:");
    Console.WriteLine($"{cashTill[3] * 20} in twenties");
    Console.WriteLine($"{cashTill[2] * 10} in tens");
    Console.WriteLine($"{cashTill[1] * 5} in fives");
    Console.WriteLine($"{cashTill[0]} in ones");
    Console.WriteLine();
}

static string TillAmountSummary(int[] cashTill)
{
    return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

}
