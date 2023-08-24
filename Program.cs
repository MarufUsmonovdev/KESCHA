// NAME
System.Console.WriteLine($"Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

//AGE
System.Console.WriteLine("Enter your age: ");
string ownage = Console.ReadLine();
System.Console.WriteLine($"Converting... ");
int age = Convert.ToInt32(ownage);
System.Console.WriteLine($"Seccesfully converted {age}");
int KeschaAge = 2;
int differenceAge = age - KeschaAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {differenceAge}");


System.Console.WriteLine($"You are older than Kescha's age: {differenceAge > 0}");
System.Console.WriteLine($"You are younger than Kescha's age: {differenceAge < 0}");
System.Console.WriteLine($"Your age the same with Kescha: {differenceAge == 0}");
System.Console.WriteLine($"Your age is not equel Kescha's age: {differenceAge != 0}");