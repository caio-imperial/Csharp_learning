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
            string num1_string = null;
            string num2_string = null;
            string num3_string = null;

            WriteLine("Fill in the request below !!!");
            // wait the user insert a int no null
            do{

                Write("Number 1: ");
                num1_string = ReadLine();
                if (string.IsNullOrEmpty(num1_string))
                    WriteLine("Invalid");

            } while (string.IsNullOrEmpty(num1_string));

            do{

                Write("Number 2: ");
                num2_string = ReadLine();
                if (string.IsNullOrEmpty(num2_string))
                    WriteLine("Invalid");

            } while (string.IsNullOrEmpty(num2_string));

            do{

                Write("Number 3: ");
                num3_string = ReadLine();
                if(string.IsNullOrEmpty(num3_string))
                    WriteLine("Invalid");
            } while (string.IsNullOrEmpty(num3_string));

            //convert string to int
            num1 = int.Parse(num1_string);
            num2 = int.Parse(num2_string);
            num3 = int.Parse(num3_string);

            // sum 3 number type before
            int sum = num1 + num2 + num3;

            // show the sum in console
            WriteLine($"{num1} + {num2} + {num3} = {sum}");

            // show the total in cosole
            WriteLine($"Total: {sum}");
        }
    }
}
