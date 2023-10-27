Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1,5);
        var roll = random.Next(1,6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}


// This method should retrieve user input and determine if the user wants to play again 
bool ShouldPlay()
{
    string readResult = Console.ReadLine().ToLower();
    return readResult == "y" ? true:false;
}

// This method should determine if the player has won or lost
string WinOrLose(int target, int roll)
{
    return target > roll ? "You lose!":"You win!";

}