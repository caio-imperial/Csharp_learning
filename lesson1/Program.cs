// Program calculate your age based in birth year
using static System.Console;

namespace lesson1
{
    class Program
    {
        static void Main()
        {
            //variables
            string name;
            int age = 0;

            // call the class
            Person_Console person = new Person_Console();
            // write in console
            WriteLine("Fill in the request below !!!\n");
            // call method to request name
            name = person.first_name();

            // call method to request birth year
            age = person.calculate_age();

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
    // class for validate name and year insert for user
    public class Person_Console{
        private int year_now = DateTime.Now.Year;
        private string name;
        private int year;
        private int age;
        private bool error = true;
        public string first_name()
        {
            // wait  insert user a name different the null
            do{

                Write("First Name: ");

                //get input
                name = ReadLine();

                // erro mensage
                if (string.IsNullOrEmpty(name))
                    WriteLine("Invalid");

            } while (string.IsNullOrEmpty(name));
            return name;
        }
        public int calculate_age(){
            bool error = true;
            do{
                try{
                    //write  in console
                    Write("Your birth year:");
                    //get input
                    year = int.Parse(ReadLine());
                    error = false;
                }catch{
                    // erro mensage
                    WriteLine("Invalid");
                }
            } while (error == true);

            age =  year_now - year;

            return age;
        }
    }
}
