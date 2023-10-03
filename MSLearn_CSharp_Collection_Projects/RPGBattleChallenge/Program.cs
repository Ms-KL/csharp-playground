/*
    https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/3-challenge

    Hero + Monster
    - start with same health score

    Hero's turn:
    - generate random value
        - subtract from monster health
    
    Monster impact:
    - if monster health > 0
        - monster turn and attack hero
    
    Loser:
    - first to 0 --> game ends

    ----------------------------------
    Structure:
    ----------------------------------    

    Players:        hero, monster
    outer loop:     do-while or while
    HP:             10 (max)
    Attack value:   1-10 (random)

    First turn:     hero
    print monster:  HP lost + remaining
    If:             MHP = 0, hero win, game ends
                    MHP > 0, monster turn
    Next:           monster
    print hero:     HP lost + remaining
    If:             HHP = 0, monster win, game ends
                    HHP > 0, hero turn

    ----------------------------------
    Test Output:
    ----------------------------------   
    Monster was damaged and lost 1 health and now has 9 health.
    Hero was damaged and lost 1 health and now has 9 health.
    Monster was damaged and lost 7 health and now has 2 health.
    Hero was damaged and lost 6 health and now has 3 health.
    Monster was damaged and lost 9 health and now has -7 health.
    Hero wins!
*/
Random random = new Random();

int heroHP = 10;
int monsterHP = 10;
bool heroTurn = true;
int damage = 0;
string winner = "Undecided";
string damaged = "";
int remaining = 0;

do 
{
    damage = random.Next(1,11);  

    if (heroTurn)
    {
        // Console.WriteLine("Hero's Turn");
        monsterHP -= damage;
        damaged = "Monster";
        remaining = monsterHP;
        heroTurn = false;
        if (monsterHP <= 0) 
            {
                winner = "Hero";
            }     
    }
    else
    {
        // Console.WriteLine("Monster's Turn");
        heroHP -= damage;
        damaged = "Hero";
        remaining = heroHP;
        heroTurn = true; 
        if (heroHP <= 0) 
            {
                winner = "Monster";
            }     
    }

    Console.WriteLine($"{damaged} was damaged and lost {damage} health and now has {remaining} health.");

} while (winner == "Undecided");

Console.WriteLine($"{winner} wins!");


// ----- SOLUTION

int hero = 10;
int monster = 10;

Random random = new Random();

do
{
    // hero being first, will deal monster damage
    int damage = random.Next(1, 11);
    monster -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monster} health.");

    if (monster <= 0) continue;
    // if the monster is dead (less than or = to 0), continue to while block, otherwise complete loop

    damage = random.Next(1, 11);
    hero -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {hero} health.");

    // now ask the while question. If false, do the loop again

} while (hero > 0 && monster > 0);
// do the loop while hero and monster are more than 0 HP

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
// is hero more than monster? hero wins, else monster wins

