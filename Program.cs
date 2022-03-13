class Person 
{
    static void Main(string[] args)
    {
        //Call the "Name" method defined above

        Name();
        MyInput();
    }

    static void Name() {
        //Example of a simple method

        var firstname = "James";
        var secondname = "McConnell";

        Console.WriteLine("My name is " + firstname + " " + secondname);
  
    }

    static void MyInput() {

        Console.WriteLine("Please enter your name: ");

        string text_input = Console.ReadLine();

        Console.WriteLine("Your name is " + text_input);
        Console.ReadLine();
    }

  }