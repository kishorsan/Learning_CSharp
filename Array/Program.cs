// See https://aka.ms/new-console-template for more information

String[] names = new String[3];
names[0] = "Karan";
names[1] = "Kroyesha";
names[2] = "Kushi";

Console.WriteLine($"Heyy {names[0]}, {names[1]} and {names[2]} how are y'all");

// names[3] = "Ranja";
Console.WriteLine($"I wanna call u Macha {names[0]}");
Console.WriteLine($"Fine auther!");
names[0] = "Macha";

Console.WriteLine($"How does it feel to have an new name {names[0]}");
Console.WriteLine($"Weird but i will get used to this 😁!");

String[] acts = { "Clearnig", "Roaming", "Eating", "Having fun" }; // older way of doing things
String[] acts_pt2 = [ "Clearnig", "Roaming", "Eating", "Having fun" ]; // newer way of doing things


Console.WriteLine($"The length of my activities is {acts.Length}");

/*
array.Length = gives length of array !
string.Length = gives length of string !
*/

foreach (string act in acts)
{
    Console.WriteLine($"I am the act of {act}");
}

// Int array

int[] collectors = [127, 365, 890, 452, 764, 157, 984];
int sum = 0, bin = 0;
foreach (int price in collectors)
{
    sum += price;
    bin++;
    Console.WriteLine($"{bin} Item prices are as follows {price}");
}

Console.WriteLine($"The total price would be {sum}");

// Objects Array

Car car1 = new Car("Mercidis");
Car car2 = new Car("Lambo");
Car car3 = new Car("BMW");

Car[] cars = new Car[3];
// OR
Car[] parkingLot = { car1, car2, car3 };

class Car
{
    public String Model { get; set; }
    public Car(String model)
    {
        this.Model = model;
    }
}