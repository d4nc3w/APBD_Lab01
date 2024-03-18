// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insert your name: ");
        string name = Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + ". Hello, " + name + "!");
        }

        Student student = new Student(name);
        Console.WriteLine(student.firstName);
        
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int result = averageNum(numbers);
        Console.WriteLine("The average number is: " + result);
        
        int max = maxValue(numbers);
        Console.WriteLine("The max value is: " + max);
    }
    
    public static int averageNum(int[] numbers)
    {
        int sum = 0;
<<<<<<< HEAD
        for (int y = 0; y < numbers.Length; y++)
        {
            sum += numbers[y]; 
=======
        for (int x = 0; x < numbers.Length; x++)
        {
            sum += numbers[x];
>>>>>>> feature-new
        }
        int result = sum / numbers.Length;
        return result;
    }

    public static int maxValue(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}

internal class Student
{
    public string firstName;

    public Student(string firstName)
    {
        this.firstName = firstName;
    }
}

    



