// NAME
System.Console.WriteLine("Enter your name: ");
string name = System.Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

//AGE
System.Console.WriteLine("Enter your age: ");
string ownage = Console.ReadLine();
System.Console.WriteLine($"Converting... ");
int age = Convert.ToInt32(ownage);
System.Console.WriteLine($"Seccesfully converted {age}");
int Keschasage = 2;
int differenceAge = age - Keschasage;
System.Console.WriteLine($"The difference between your and Kescha's age is {differenceAge}");

