// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) 
//     {
//         var target = random.Next(1,5);
//         var roll = random.Next(1,6);

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose());
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }


// // -------- KRISTY

// // This method should retrieve user input and determine if the user wants to play again 
// bool ShouldPlay(char playAnswer)
// {
//     return playAnswer == "y" ? true:false;
// }

// // This method should determine if the player has won or lost
// string WinOrLose()
// {

//     //string result = $"You lose!";
//     string result = $"You win!";
//     return result;

// }

// Console.WriteLine(ShouldPlay('y'));
// WinOrLose();


Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay()
{
    string readResult = Console.ReadLine(); // user input
    readResult = readResult.ToLower();
    if (readResult == "y")
    {
        return true;
    }
    else
    {
        return false;
    }

}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        play = ShouldPlay();
    }


}

int GetTarget()
{
    int result = random.Next(1,6);
    return result;
}

int RollDice()
{
    int result = random.Next(1,7);
    return result;
}


// This method should determine if the player has won or lost
string WinOrLose(int target, int roll)
{
    if (target <= roll)
    {
        return "You win!";
    }
    else 
    {
        return "You lose!";
    }

}




