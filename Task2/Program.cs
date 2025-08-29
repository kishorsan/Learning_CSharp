// See https://aka.ms/new-console-template for more information

string[] fraudulentIds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string id in fraudulentIds)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}