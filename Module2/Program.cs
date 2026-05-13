// // See https://aka.ms/new-console-template for more information
// // Output: 123
// Console.WriteLine("123");
// // Output: 123
// Console.WriteLine(123);

// // Output: true
// Console.WriteLine("true");
// // Output: True
// Console.WriteLine(true);

// // Declare a variable of type string and assign it a value
// string firstName;
// firstName = "John";
// // Output: John
// Console.WriteLine(firstName);

// // Variable Examples
// char userOption;

// int gameScore;

// decimal particlesPerMillion;

// bool processedCustomer;

// // Changing the value of a variable
// string firstName;
// firstName = "Bob";
// Console.WriteLine(firstName);
// firstName = "Liem";
// Console.WriteLine(firstName);
// firstName = "Isabella";
// Console.WriteLine(firstName);
// firstName = "Yasmin";
// Console.WriteLine(firstName);

// string firstName = "Bob";
// int number = 3;
// float decimalNumber = 34.4f;

// // print Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
// Console.WriteLine($"Hello, {firstName}! You have {number} messages in your inbox. The temperature is {decimalNumber} celsius.");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);


string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
  c:\Exercise\{projectName}\data.txt");
Console.Write("\n");
Console.WriteLine($@"{russianMessage}:
  c:\Exercise\{projectName}\data.txt");

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);