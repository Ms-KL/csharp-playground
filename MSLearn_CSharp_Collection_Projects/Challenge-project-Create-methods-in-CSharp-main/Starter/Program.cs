using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
   
    // Exits the game if terminal is resized
    if (TerminalResized())
    {
        Console.WriteLine("\nConsole was resized. Program exiting");
        Thread.Sleep(1500);
        shouldExit = true;
        Console.Clear();
    }
    else
    {
        Move(3); // add speed argument as required (3). Default = 1
        // check if food consumed method is working
        if(ConsumedFood())
        {
            // change player appearance when food consumed
            ChangePlayer();

            // redisplay food when food consumed
            ShowFood();
        }
        // check if player appearance = (X_X)
        else if(ShouldFreeze())
        {
            // temp freeze player
            //Console.WriteLine("Player Frozen");
            FreezePlayer();

            // respawn player once unfrozen
            ChangePlayer();

            // redisplay food once unfrozen
            ShowFood();

        }
    }
    
}

// Returns true if player location = food location (consumed)
bool ConsumedFood()
{
    return playerX == foodX && playerY == foodY;
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{

    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);

}

// Check if player should freeze
bool ShouldFreeze()
{
    return player == states[2];
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    Console.WriteLine("Sorry, your player is frozen! Please wait.");
    System.Threading.Thread.Sleep(3000);
    player = states[0];
    Console.Clear();
}

// Optional: Check if player could increase speed
bool couldIncrease()
{   
    return player == states[1];
}

// Reads directional input from the Console and moves the player
void Move(int playerSpeed = 1) 
{
    int lastX = playerX;
    int lastY = playerY;
    
    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            if (couldIncrease())
            {
                playerY-= playerSpeed; 
            }
            else 
            {
                playerY--;
            }

            break;
		case ConsoleKey.DownArrow: 
            if (couldIncrease())
            {
                playerY+= playerSpeed; 
            }
            else 
            {
                playerY++;
            }
            break;
		case ConsoleKey.LeftArrow:  
            playerX--; 
            break;
		case ConsoleKey.RightArrow: 
            playerX++; 
            break;
		case ConsoleKey.Escape:  
            Console.WriteLine("\nYou Quit the Game. Thanks for playing!\n");   
            Thread.Sleep(1500);
            shouldExit = true; 
            Console.Clear();
            break;
        default: // non directional input = exit game
            Console.WriteLine("\nInvalid direction, you lose! Game Exiting.\n");
            Thread.Sleep(1500); // delay so message displays
            shouldExit = true;
            Console.Clear(); // clear console so clean for next command
            break;
    }

    // Increase player speed based on left and right movement
    if (couldIncrease())
    {
        playerSpeed += 3;

    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);


}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);

}