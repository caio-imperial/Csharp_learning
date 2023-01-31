using static System.Console;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            bool erro = true;

            WriteLine("Fill in the request below !!!");

            // wait the user insert a int
            do{
                try{
                    Write("Number 1: ");
                    num1 = int.Parse(ReadLine());
                    erro = false;
                }
                catch{
                        WriteLine("Invalid number");
                }
            } while (erro == true);
            erro = true;

            do{
                try{
                    Write("Number 2: ");
                    num2 = int.Parse(ReadLine());
                    erro = false;
                }
                catch{
                    WriteLine("Invalid number");
                }
            } while (erro == true);
            erro = true;

            do{
                try{
                    Write("Number 3: ");
                    num3 = int.Parse(ReadLine());
                    erro = false;
                }
                catch{
                    WriteLine("Invalid number");
                }
            } while (erro == true);

            // sum 3 number type before
            int sum = num1 + num2 + num3;

            // show the sum in console
            WriteLine($"{num1} + {num2} + {num3} = {sum}");

            // show the total in cosole
            WriteLine($"Total: {sum}");
        }
    }
}
