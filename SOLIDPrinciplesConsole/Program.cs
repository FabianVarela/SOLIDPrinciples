namespace SOLIDPrinciplesConsole
{
    using System;
    using SingleResponsibility;
    using SingleResponsibility.Class;
    using OpenClose;
    using OpenClose.Class;
    using LiskovSubstitution;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Single Responsibility");
            Console.WriteLine("2. Open Close");
            Console.WriteLine("3. Liskov Substitution");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SRP();
                    break;
                case 2:
                    OCP();
                    break;
                case 3:
                    LSP();
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

        static void LSP()
        {
            Console.WriteLine("---------------Liskov Substitution Principle---------------");
            Console.WriteLine("Calculate the shape areas");

            Console.WriteLine("**********ELLIPSE**********");

            Console.WriteLine("Type the major axis of a circle");
            int majorAxis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the minor axis of a circle");
            int minorAxis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********RECTANGLE**********");

            Console.WriteLine("Type the breadth of the rectangle");
            int breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the length of the rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            LSPAreaCalculator areaCalculator = new LSPAreaCalculator();

            double ellipseArea = areaCalculator.SetCircleArea(majorAxis, minorAxis);
            int rectangleArea = areaCalculator.SetSquareArea(breadth, length);

            Console.WriteLine("**********RESULTS**********");
            Console.WriteLine($"Ellipse area: {ellipseArea}");
            Console.WriteLine($"Reactangle area: {rectangleArea}");
        }
    }
}
