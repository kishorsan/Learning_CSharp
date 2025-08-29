// See https://aka.ms/new-console-template for more information

// Basics of C#, Method invocation and such

/*
Console.WriteLine("Hello C#!");

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

int randInt = dice.Next(200, 900);
Console.WriteLine(randInt);

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(10, 90);

Console.WriteLine($"First roll {roll1}");
Console.WriteLine($"Second roll {roll2}");
Console.WriteLine($"Third roll {roll3}");

int roll4 = dice.Next();


int firstVal = 500;
int secondVal = 400;
int largerVal;

largerVal = Math.Max(firstVal, secondVal);

Console.WriteLine(largerVal);

*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled tripples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }

}

if (total >= 16)
{
    Console.WriteLine("You win a car");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two !");
}
else
{
    Console.WriteLine("You win a kitten");
}

/*
string message = "The quick brow fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

*/