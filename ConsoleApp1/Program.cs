// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// verbatim literals

// using @ symbol to ignore escape sequence and also to be able to write multiline printable statements !

// ## Code --

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// ## Output --

/*
Generating invoices for customer "Contoso Corp" ...

Invoice: 1021            Complete!
Invoice: 1022            Complete!

Output Directory:
c:\invoices

日本の請求書を生成するには：
    c:\invoices\app.exe -j
*/

// String concatination using + operator to append a string at the end of another string !
// String interpolation using {} 

// Combine verbatim literals and string interpolation (interpolation just like f-string)

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// Overloading of Operator ----===>> 
// You've seen three uses for the parenthesis operator: method invocation, order of operations and casting

