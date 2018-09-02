namespace SOLIDPrinciplesConsole
{
    using SingleResponsibility;
    using SingleResponsibility.Class;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Single Responsibility Principle---------------");
            Console.WriteLine("Initialize the validations");

            SRPValidation validation = new SRPValidation(new ValidationText(), new ValidationEmail(), new ValidationNumber());

            Console.WriteLine("Type the name");
            string name = Console.ReadLine();

            Console.WriteLine("Type the last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Type the email");
            string email = Console.ReadLine();

            Console.WriteLine("Type the age number");
            string age = Console.ReadLine();

            string result = validation.ValidateForm(name, lastName, email, age);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
