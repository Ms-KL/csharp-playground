
// https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/4-challenge-1

/*
    COIN FLIP:

    2. use random class to generate a value
        ** consider range of numbers required

    3. based on value generated:   
        - use conditional operator to display heads or tails
        - 50% changes result is heads/tails
    
    4. code easy to read and few lines
        - 3 lines should be enough

*/

// create new instance of random class as coin variable
Random coin = new Random();

// range required
int flip = coin.Next(0,2);
// 0-1 

// if random coin flip is 1, then heads, else tails

Console.WriteLine(flip > 0 ? "heads" : "tails");


// alternative (hard to read):
Console.WriteLine((coin.Next(0,2) == 0) ? "heads" : "tails");