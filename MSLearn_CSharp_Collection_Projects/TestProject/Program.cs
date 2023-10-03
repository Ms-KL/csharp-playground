
// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Kristy is learning C#");

// // new: create object/instance of Random class as dice variable
// Random dice = new Random(); 

// // Next(): stateful, if above line is not in existence, cannot access without (1, 7) state
// // int roll = dice.Next();
// int roll = dice.Next(1,7);

// // stateless method within Console. class
// Console.WriteLine(roll); 

// -------------

// overloaded methods (enables any number of parameters + sometimes diff datatypes)
// Random dice = new Random();
// int roll1 = dice.Next(); // no boundary
// int roll2 = dice.Next(101); // max boundary (result = 0-100)
// int roll3 = dice.Next(50, 101); // min/max boundaries

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice.Next()

// -------------

// using System;

// int firstValue = 500; // initialise
// int secondValue = 600; // initialise
// int largerValue = Math.Max(firstValue, secondValue); // decare variable

// Console.WriteLine(largerValue);


// --------------------

// // step 1:
//     // create "new" instance of "System.Random" class
//     // store reference to object variable named "dice"

// Random dice = new Random();
// // class objectvariable = type class

// // step 2:
//     // call the Random.Next() method on dice object x3 times
//     // provide min and max parameters for next
//     // save values of each method on dice object individually

// int roll1 = dice.Next(1, 7);
//     // variable type
//     // variable name
//     // =
//     // objectvariable
//     // callNextmethod
//     // input parameters

// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// // step 3:
//     // sum results
//     // save as new varialbe

// int total = roll1 + roll2 + roll3;

// // step 4:
//     // use method to return results using string interpolation

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("Triple! +6 bonus");
//     total +=6;
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry you lose");
// }

// // --------
// // Boolean

// string message = "My name is banana";
// bool result = message.Contains("Kristy");
// Console.WriteLine(result);

// if (message.Contains("banana"))
// {
//     Console.WriteLine("Why am I yellow?");

// ----------------------------

// Random dice = new Random(); // new instance dice object of Random class

// int roll1 = dice.Next(1, 7); // initialise variables to method call with min/max parameters
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// roll1 = 6;
// roll2 = 6;
// roll3 = 6;

// int total = roll1 + roll2 + roll3; // initialise variable to sum of method call objects

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}"); // return values with string interpolatiion

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // if this or that or thing 
// {
//     if ((roll1 == roll2) && (roll2 == roll3))  // if this and that then return result and increment
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }

// }


// if (total >= 15) // if total is more than and equal to 15, return win message
// {
//     Console.WriteLine("You win!");
// }
// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// ----------------------------

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // if this or that or thing 
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3))  // if this and that then return result and increment
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// }

// if (total >= 15) // if total is more than and equal to 15, return win message
// {
//     Console.WriteLine("You win!");
// }
// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose."); // if total is less than 15, return lost message
// }

// ----------------------------

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// roll1 = 3;
// roll2 = 3;
// roll3 = 1;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine($"Total = {total} -> You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine($"Total = {total} -> You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine($"Total = {total} -> You win a trip for two!");
// }
// else
// {
//     Console.WriteLine($"Total = {total} -> You win a kitten!");
// }





// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-if-elseif-else/4-challenge
// --------------------------------------------

/*
    RULES
    1. Your code should only display one message

    2. if user subscription expires in 10 days or less, display this message:
    Your subscription will expire soon. Renew now!

    3. If the user's subscription will expire in five days or less, display the messages:
    Your subscription expires in _ days.
    Renew now and save 10%!

    NOTE: Be sure to replace the _ character displayed in the message above with the value stored in the variable daysUntilExpiration when you construct your message output.

    4.  If the user's subscription will expire in one day, display the messages:
    Your subscription expires within a day!
    Renew now and save 20%!

    5.  If the user's subscription has expired, display the message:
    Your subscription has expired.

    6. If the user's subscription doesn't expire in 10 days or less, display nothing.

    TASK:
    Create an if-else statement that displays a message about when the subscription will expire.
        Use an else if to ensure each expiration rule is accounted for.
    Create a separate if statement that displays a discount offer.
*/

// ------------------- result ----------------------

// Random random = new Random(); // initialise new instance of random class and call it random
// int daysUntilExpiration = random.Next(12); // call Next() method with max parameter of 12
// int discountPercentage = 0; // create variable with 0 value

// // Notice that this code will generate a random number with a value of 0 - 11. The random number is assigned to an integer variable named daysUntilExpiration. You have another integer variable named discountPercentage that is initialized to 0.
// daysUntilExpiration = 1;
// Console.WriteLine($"Days Until Expiration: {daysUntilExpiration}");

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;

// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%!");
// }





// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-arrays/2-exercise-array-basics
// --------------------------------------------

// // arrays

// // create array that holds 3 string values
// string[] fraudulentOrderIDs = new string[3];
// // py: list = []
// // alt: int[] numberOfThings = new int[3]

// // assign values:

// fraudulentOrderIDs[0] = "A123"; // index number
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // additional - [3] will be out of range and will throw error

// -----
// // inialise array

// string[] fraudulentOrderIDs = {"A123","B456","C789"};

// Console.WriteLine($"First: \t {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second:  {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: \t {fraudulentOrderIDs[2]}");

// // reassign

// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// // len

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-arrays/3-exercise-foreach
// --------------------------------------------

// Loops


// string[] fruits = {"banana", "orange", "mango"};
// foreach (string fruit in fruits)
// {
//     Console.WriteLine(fruit);
// }

// -----

// int[] inventory = { 200, 450, 700, 175, 250 };
// int total = 0;
// int bin = 0;

// foreach (int item in inventory)
// {
//     bin++;
//     total += item;
//     Console.WriteLine($"Bin {bin} = {item} items (Running total: {total})");
// }
// Console.WriteLine($"itemsTotal = {total}!");

// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-arrays/4-challenge
// --------------------------------------------

/*
    Code challenge - Report the Order IDs that need further investigation

    Summary:
    Your team has found a pattern. 

    Orders that: 
        - start with the letter "B" ...
            - encounter fraud at a rate 25 times greater than the normal rate. 

    You write new code that: 
        - outputs the Order ID of new orders where... 
            - the Order ID starts with... 
                - the letter "B". 
                    - This will be used by the fraud team to investigate further.

    Steps:
    1. Declare an array and initialize it to contain the following elements:
    these are Order ID data

        B123
        C234
        A345
        C15
        B177
        G3003
        C235
        B179

    2. Create a foreach statement to iterate through each element of your array.

    3. Report the Order IDs that start with the letter "B".
    You need to evaluate each element of the array. 
    Report the potentially fraudulent Order IDs by detecting the orders that start with the letter "B". 
    To determine whether or not an element starts with the letter "B", use the String.StartsWith() method. 
        string name = "Bob";
        if (name.StartsWith("B"))
        {
            Console.WriteLine("The name starts with 'B'!");
        }
    
    Output:
    B123
    B177
    B179

    TIP:

    As you loop through each element in your array, you'll need an if statement. 
    The if statement will need to use a method on the string class to determine if a string starts with a specific letter. 

*/


// ------

// // declare array of values:

// string[] orderIDs = {
//     "B123",
//     "C234",
//     "A345",
//     "C15",
//     "B177",
//     "G3003",
//     "C235",
//     "B179",
// };

// foreach (string id in orderIDs)
// {
//     if (id.StartsWith("B"))
//     {
//         Console.WriteLine(id);
//     }
// };







// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-readable-code/1-introduction
// --------------------------------------------


// low quality comments:

// Random random = new Random(); // initialise random class instance
// string[] orderIDs = new string[5]; // array with 5 string elms

// // Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++) 
// // i = iteration
// // continue the loop while i < length of array
// // increase iteration count by one each loop

// {
//     // Get a random value that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);

//     // Convert the random value into a char, then a string
//     string prefix = Convert.ToChar(prefixValue).ToString();

//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");

//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;

// }

// // Print out each orderID
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// ------------

// /*
//   The following code creates five random OrderIDs
//   to test the fraud detection process.  OrderIDs 
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.
// */
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }










// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-readable-code/4-exercise-use-whitespace
// --------------------------------------------

/*
    The following code reverses a string,
    and counts the number of times a specific character appears.
    It returns the reversed string, the specific character and the number of times it appears.

*/
// string message = "The quick brown fox jumps over the lazy dog.";

// char[] reversedMessage = message.ToCharArray();
// Array.Reverse(reversedMessage);

// int letterCount = 0;

// foreach (char letter in reversedMessage) 
// { 
//     if (letter == 'o')
//     { 
//         letterCount++; 
//     } 

// }

// string new_message = new String(reversedMessage);

// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {letterCount} times.");






// --------------------------------------------
// https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/2-exercise-boolean-expressions
// --------------------------------------------

// Console.WriteLine("a" == "a"); // True
// Console.WriteLine("a" == "A"); // False
// Console.WriteLine(1 == 2); // False

// string myValue = "a";
// Console.WriteLine(myValue == "a"); // True

// // equality check and cleanup using string built-in helper methods
// Console.WriteLine("-------------------------------");
// Console.WriteLine("Cleanup values using string helper methods");
// Console.WriteLine("-------------------------------");
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
// // remove white space and change values to lowercase, check for equality

// Console.WriteLine("-------------------------------");
// Console.WriteLine("Inequality Operator");
// Console.WriteLine("-------------------------------");
// Console.WriteLine("a" != "a"); // false
// Console.WriteLine("a" != "A"); // true
// Console.WriteLine(1 != 2); // true

// string myNewValue = "a";
// Console.WriteLine(myNewValue != "a"); // false

// Console.WriteLine("-------------------------------");
// Console.WriteLine("Comparison Operator");
// Console.WriteLine("-------------------------------");

// Console.WriteLine(1 > 2); // false
// Console.WriteLine(1 < 2); // true
// Console.WriteLine(1 >= 1); // true
// Console.WriteLine(1 <= 1); // true

// Console.WriteLine("-------------------------------");
// Console.WriteLine("Methods returning true or false");
// Console.WriteLine("-------------------------------");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox")); // true
// Console.WriteLine(pangram.Contains("cow")); // false

// Console.WriteLine("-------------------------------");
// Console.WriteLine("Logical Negotiation");
// Console.WriteLine("-------------------------------");

// // the following creates the same output

// Console.WriteLine(pangram.Contains("fox") == false); // false
// Console.WriteLine(!pangram.Contains("fox")); // false

// string pangram2 = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram2.Contains("fox")); // false
// Console.WriteLine(!pangram2.Contains("cow")); // true







// --------------------------------------------
// https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/3-exercise-conditional-operator
// --------------------------------------------



/*
    Conditional Operator
    ---------------------
    <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

    TASK:
    Suppose you need to quickly determine whether a customer's purchase is eligible for a promotional discount. 
    
    The details for the promotion indicate that: 
    
    when a purchase value is greater than $1000, 
        the purchase is eligible for a $100 discount. 
    
    If the purchase amount is $1000 or less, 
        the purchase is eligible for a $50 discount.

*/

// int saleAmount = 10;
// string discountString = saleAmount > 1000 ? "$100 Discount" : "$50 Discount";
// Console.WriteLine(discountString);

// // same as

// int discountInt = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discountInt}");

// // same as

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// // same as

// if (saleAmount > 1000)
//     {
//         discountInt = 100;
//     }
// else
//     discountInt = 50;

// Console.WriteLine($"Discount: {discountInt}");









// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-code-blocks/2-exercise-variable-scope
// --------------------------------------------


// // variable inside code block

// bool flag = true; // global variable

// if (flag)
// {
//     int valueIn = 10; // local variable
//     Console.WriteLine($"inside of codeblock: {valueIn}");
// }

// // cannot access outside of codeblock:
// // Console.WriteLine($"Outside of code block: {value}");

// // -------

// // variable outside code block

// int valueOut; // global variable without initialization

// if (flag)
// {
//     valueOut = 50; 
//     Console.WriteLine("Inside of code block: " + valueOut);
// }

// // still not working due to variable being compiled in the if statement
// // Console.WriteLine($"Outside of code block: {valueOut}"); 

// // -------

// int valueOut2 = 0; // global variable WITH initialization

// if (flag)
// {
//     valueOut2 = 20; // reassign
//     Console.WriteLine("Inside of code block: " + valueOut2);
// }
// Console.WriteLine("Outside of code block: " + valueOut2);


// // ------


// int valueOut3 = 5; // global variable WITH initialization

// if (flag)
// {
//     int valueOut4 = 6; // reassign
//     valueOut3 = valueOut3 + valueOut4;
//     Console.WriteLine("Inside of code block: " + valueOut3);
// }
// Console.WriteLine("Outside of code block: " + valueOut3);







// --------------------------------------------
// https://learn.microsoft.com/en-gb/training/modules/csharp-code-blocks/3-exercise-remove-if-statements
// --------------------------------------------

// // If Statement with code block

// using System.Diagnostics.CodeAnalysis;

// bool flag = true;

// if (flag)
// {
//     Console.WriteLine(flag);
// }

// // no curly braces
// if (flag)
//     Console.WriteLine(flag);

// // one line --> NEVER USE
// if (flag) Console.WriteLine(flag);

// // example -> readability issues
// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");

// // better
// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");


// ----------------------------
//https://learn.microsoft.com/en-gb/training/modules/csharp-code-blocks/6-knowledge-check
// -----------------------------

// int first = 1;

// if (first > 0)
// {
//     int second = 8;
//     first = first + second;
// }

// Console.WriteLine(first);

// ----------------

// int first = 5;

// if (first > 0)
// {
//     int second = 6;
// }

// first = first + second;

// Console.WriteLine(first);





// ----------------------------
//https://learn.microsoft.com/en-us/training/modules/csharp-switch-case/2-exercise-switch-case
// -----------------------------

/*
The below code uses employeeLevel to understand what title the employeeName has.
switch = if
case = boolean question
break = stop after true
default = else


*/


// int employeeLevel = 100;
// string employeeName = "Kristy Gray";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         // title = "Junior Associate";
//         // break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// // if statement equiv

// // if (employeeLevel == 100)
// //     title = "Junior Associate";
// // else if (employeeLevel == 200)
// //     title = "Senior Associate";
// // else if (employeeLevel == 300)
// //     title = "Manager";
// // else if (employeeLevel == 400)
// //     title = "Senior Manager";
// // else
// //     title = "Associate";

// // Console.WriteLine($"{employeeName}, {title}");





/* --------------------------------------------------
https://learn.microsoft.com/en-gb/training/modules/csharp-for/2-exercise-for
--------------------------------------------------------*/


/*
for (counter variable initialisation; condition for counter, increment for counter)
print (counter value)
*/

// // count up:
// Console.WriteLine("Count Up");
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// // count down:
// Console.WriteLine("Count Down");
// for (int j = 10; j >=0; j--)
// {
//     Console.WriteLine(j);
// }

// // mixed pattern (count up by 3):
// Console.WriteLine("Count Up by 3");
// for (int counter = 0; counter < 10; counter += 3)
// {
//     Console.WriteLine(counter);
// }

// -----------

// // count up to 7 then break:
// Console.WriteLine("Count Up to ");
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// ---------
// for loop through array until condition is met
// foreach will loop through every item in the array

// Console.WriteLine("backward -->");
// // backward
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length -1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// // initialise string array "names" and assign values
// // for (
//     // iteration = start with the length of names array, less 1. (length includes 0 as positon 1, so need to minus 1))
//     // decrement the iteration counter by one each iteration
//     // loop while counter is more than or equal to 0
// // print the name of the list (starting from the end of the list)

// Console.WriteLine("forward -->");
// // forward
// string[] names2 = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names2.Length; i++)
// {
//     Console.WriteLine(names2[i]);
// }



//-------------------------
// FOREACH LIMITATION --> Can't reassigning looping variable
// FOR ABILITY --> Can reassign looping variable

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// ---------------------------------- FOR without {}

// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

// // ------------------------------------ alt with prints (need {} for multiple actions in if/for)

// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
//     if (names[i] == "David") 
//     {
//         names[i] = "Sammy";
//         Console.WriteLine($"Changing David to: {names[i]}");
//     }
// }

// Console.WriteLine("Final Array with changes to David: ");
// foreach (var name in names) Console.WriteLine(name);









/* ----------------------------------------------
    https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/2-exercise-do-while-continue
-------------------------------------------------- */


// Random random = new Random();

// Console.WriteLine("Do-While");
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);


// // -------------

// Console.WriteLine("While");
// int current2 = random.Next(1, 11);

// while (current2 >= 3)
// {
//     Console.WriteLine(current2);
//     current2 = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current2}");

// // -------------

// /*
//     Do-While ensures loop will iterate at least once
//     0) intialise random variable to current3
//     1) assign new random variable (current3) between 1 and 10
//     2) if current3 >= 8
//         2.1 TRUE) move to the end of the block
//         2.2 FALSE) print current3 to the console
//     3) if curent3 is not equal to 7
//         3.1 TRUE) start the do-while loop again
//         3.2 FALSE) stop the do-while loop
// */
// Console.WriteLine("Do-While Continue");
// int current3 = random.Next(1, 11);

// do
// {
//     current3 = random.Next(1, 11);

//     if (current3 >= 8) continue;

//     Console.WriteLine(current3);

// } while (current3 != 7);




/* ------------------------------------------------------------------------

    FOREACH, FOR, DO-WHILE, WHILE

    FOREACH         foreach (type elm in list)
                    {
                        code to execute for every iteration
                        cannot nest another foreach loop
                    }

    
    FOR             for (type iteration = value to iterate; condition to loop while true; iteration value increment)
                    {
                        code to execute while condition is true
                        {can nest another for loop}
                    }


    DO-WHILE        do
                    {
                        code to execute immediately and 
                            then only while condition is met
                            
                    } while (condition to do loop again);


    WHILE           while (condition to loop)
                    {
                        code to execute only while condition is met
                    }
                    

 ------------------------------------------------------------------------ */





 // ------------------------------------------------------------------------

 //     https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements

// -------------------------------------------------------------------------

//  USER INPUT

// string? readResult; // string? permits a null value
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine(); 
// } while (readResult == null); // read the line until something is entered by the user


// USER ENTER STRING WITH CERTAIN CONDITIONS

string? readResult; // null string ok
bool validEntry = false; // isValid?
Console.WriteLine("Enter a string containing at least three characters:"); // user prompt
do
{
    // execute this immediately and then additional times while condition is met
    readResult = Console.ReadLine(); // .ReadLine() = user input
    if (readResult != null) // if user enters something
    {
        if (readResult.Length >= 3) // if user input is 3+ characters
        {
            validEntry = true;  // while condition no longer met
        }
        else
        {
            Console.WriteLine("Your input is invalid, Please try again.");     
        }
    }
} while (validEntry == false);

// USER ENTER NUMERIC VALUE (NOT STRING)
// convert string to integer    
// int.TryParse()     returns a boolean value

// capture user input in a string variable named readResult
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
// if value in readResult represents a valid integer as a string, convert readResult from do-while loop to integer as numericValue variable
// eg: if "7" then convert to 7 


