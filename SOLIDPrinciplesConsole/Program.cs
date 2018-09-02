namespace SOLIDPrinciplesConsole
{
    using SingleResponsibility;
    using SingleResponsibility.Class;
    using OpenClose;
    using OpenClose.Class;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Single Responsibility");
            Console.WriteLine("2. Open Close");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SRP();
                    break;
                case 2:
                    OCP();
                    break;
            }

            Console.ReadKey();
        }

        static void SRP()
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
        }

        static void OCP()
        {
            Console.WriteLine("---------------Open Close Principle---------------");
            Console.WriteLine("Calculate the shape areas");

            Console.WriteLine("**********CIRCLE**********");

            Console.WriteLine("Type the radius of a circle");
            int raduis = Convert.ToInt32(Console.ReadLine());

            Circle circle = new Circle
            {
                Radius = raduis
            };

            Console.WriteLine("**********RECTANGLE**********");

            Console.WriteLine("Type the width of the rectangle");
            int recWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the height of the rectangle");
            int recHeight = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle
            {
                Width = recWidth,
                Height = recHeight
            };

            Console.WriteLine("**********TRIANGLE**********");

            Console.WriteLine("Type the width of the triangle");
            int triWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the height of the triangle");
            int triHeight = Convert.ToInt32(Console.ReadLine());

            Triangle triangle = new Triangle
            {
                Width = triWidth,
                Height = triHeight
            };

            OCPAreaCalculator areaCalculator = new OCPAreaCalculator();

            Console.WriteLine("**********RESULTS**********");
            Console.WriteLine($"Circle area: {areaCalculator.Area(circle)}");
            Console.WriteLine($"Reactangle area: {areaCalculator.Area(rectangle)}");
            Console.WriteLine($"Triangle area: {areaCalculator.Area(triangle)}");
        }
    }
}
