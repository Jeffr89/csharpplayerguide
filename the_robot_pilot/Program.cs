Random random = new System.Random();
int healthManticore = 10;
int healthConsolas = 15;
int round = 1;

int distanceManticore;
int cannonRange;
int cannonDmg;
Console.Write("Player 1, how far away from the city do you want to station the Manticore?  ");
distanceManticore = random.Next(0, 100);
Console.WriteLine("Player, it is your turn.");
while ((healthManticore > 0) && (healthConsolas > 0))
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round} City: {healthConsolas} Manticore: {healthManticore}");
    cannonDmg = CalculateCannonDamage(round);
    Console.WriteLine($"The cannon is expected to deal {cannonDmg} this round.");
    Console.Write("Enter desider cannon range: ");
    cannonRange = short.Parse(Console.ReadLine());
    ManticoreHit(distanceManticore, cannonRange);
    if (healthManticore > 0) healthConsolas--;
    round++;
}
CheckFinalResult(healthConsolas, healthManticore);


short CalculateCannonDamage(int round)
{
    if (((round % 5) == 0) && ((round % 3) == 0)) return 10;
    else if (((round % 5) == 0) || ((round % 3) == 0)) return 3;
    else return 1;
}

void ManticoreHit(int distanceManticore, int connanRange)
{
    if (distanceManticore < cannonRange)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (distanceManticore > cannonRange)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        healthManticore -= cannonDmg;
    }
}

void CheckFinalResult(int healthConsolas, int healthManticore)
{
    if (healthManticore == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The Consolas has been destroyed! You lost everything");
    }
}