using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_App
{
    public class Me

    {
        static void Main(string[] args)
        {

            Person person = new Person();

            Console.WriteLine("My name is " + person.MyName + " and I am " + person.MyAge + "-years-old.");

            Name();
            MyInput();
            
        }

        public static void Name()
        {
            //Example of a simple method

            var firstname = "James";
            var secondname = "McConnell";

            Console.WriteLine("My name is " + firstname + " " + secondname);

        }

        static void MyInput()
        {

            Console.WriteLine("Please enter your name: ");

            //question mark ? will make sure we can assign a null value to variable
            string? text_input = Console.ReadLine();

            Console.WriteLine("Your name is " + text_input);


            Console.WriteLine("Press 'Q' to quit: ");

            var quit = Console.ReadKey();

            Console.ReadLine();
            if (quit.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }

    }
}
