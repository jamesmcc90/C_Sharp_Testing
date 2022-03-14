class Person
{

    static void Main(string[] args)
    {
        //Call the "Name" method defined in Name()

        Name();
        MyInput();
    }

    static void Name()
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