// See https://aka.ms/new-console-template for more information
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
