using static System.Console;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Fill in the request below !!!");
            // wait the user insert a number
            Write("Number 1: ");
            int num1 = int.Parse(ReadLine());
            Write("Number 2: ");
            int num2 = int.Parse(ReadLine());
            Write("Number 3: ");
            int num3 = int.Parse(ReadLine());
            
            // sum 3 number type before
            int sum = num1 + num2 + num3;
            
            // show the sum in console
            WriteLine($"{num1} + {num2} + {num3} = {sum}");
            
            // show the total in cosole
            WriteLine($"Total: {sum}");
        }
    }
}
