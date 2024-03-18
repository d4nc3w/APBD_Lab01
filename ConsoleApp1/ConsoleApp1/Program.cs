// See https://aka.ms/new-console-template for more information

Console.WriteLine("Insert your name: ");
string name = Console.ReadLine();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + ". Hello, " + name + "!");
}

