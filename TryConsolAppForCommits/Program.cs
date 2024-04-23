// See https://aka.ms/new-console-template for more information
using TryConsolAppForCommits;

Console.WriteLine("Hello, World!");

//Add code for first commit
Console.WriteLine("First commit");


//Add code for second commit
Console.WriteLine("Second commit");

Car car1 = new Car();
car1.MaxSpeed = 10;

Car car2 = new Car();
car2.MaxSpeed = 10;

Console.WriteLine(car1.Equals(car2));

Console.WriteLine(car1.GetHashCode());
Console.WriteLine(car2.GetHashCode());

