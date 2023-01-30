// Program ask your name and birth year than show 'Hi {Your name}' after 'Your age is: {yout age}'
using static System.Console;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {   // write in console
            WriteLine(args[0]);
            WriteLine("Fill in the request below !!!\n");
            Write("Frist Name: ");

            // wait  insert user a name
            string name = ReadLine();
            //write  in console 
            Write("Your birth year:");
            // wait the user year and convert string to int.
            int year = int.Parse(ReadLine());
            // calculate the age
            int age = 2022 - year;
            
            //write in console
            WriteLine($"\nHi {name}!");
            //write age in console
            WriteLine($"Your age is: {age}");
            //check if age is over 21
            if( age >= 21 )
            {
                WriteLine("To be over 21 \n");
            }
            else 
            {
                WriteLine("To be under 21 \n");
            }
        }
    }
}
