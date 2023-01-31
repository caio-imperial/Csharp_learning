// Program ask your name and birth year than show 'Hi {Your name}' after 'Your age is: {yout age}'
using static System.Console;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //variables
            string name;
            int year;
            string year_string;
            
            // write in console
            WriteLine("Fill in the request below !!!\n");
            
            // wait  insert user a name different the null
            do {
                
                Write("Frist Name: ");
                
                //get input
                name = ReadLine();
                
                // erro mensage
                if(string.IsNullOrEmpty(name))
                    WriteLine("Invalid");
            
            }while(string.IsNullOrEmpty(name));
            do{
                
                //write  in console 
                Write("Your birth year:");
                
                //get input
                year_string = ReadLine();

                // erro mensage
                if(string.IsNullOrEmpty(year_string))
                    WriteLine("Invalid");
                
            }while(string.IsNullOrEmpty(year_string));
            
            // convert string to int
            year = int.Parse(year_string);

            // calculate the age
            int age = 2022 - year;
            
            //write in console
            WriteLine($"\nHi {name}!");
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
