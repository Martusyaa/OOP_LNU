class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть фігуру (circle, rectangle, square, triangle): ");
        string shapeType = Console.ReadLine().ToLower();

        Console.WriteLine("Виберіть колір (red, blue, green): ");
        string colorType = Console.ReadLine().ToLower();

        Color color = getColor(colorType);
        

        Shape shape;
        switch (shapeType)
        {
            case "circle":
                Console.WriteLine("Введіть радіус: ");
                double radius = double.Parse(Console.ReadLine());
                shape = new Circle(color.FillColor(), radius);
                break;
            case "rectangle":
                Console.WriteLine("Введіть ширину: ");
                double widthRect = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть висоту: ");
                double heightRect = double.Parse(Console.ReadLine());
                shape = new Rectangle(color.FillColor(), widthRect, heightRect);
                break;
            case "square":
                Console.WriteLine("Введіть довжину сторони: ");
                double side = double.Parse(Console.ReadLine());
                shape = new Square(color.FillColor(), side);
                break;
            case "triangle":
                Console.WriteLine("Введіть сторону: ");
                double sideTriangle = double.Parse(Console.ReadLine());
                shape = new Triangle(color.FillColor(), sideTriangle);
                break;
            default:
                Console.WriteLine("Невірний вибір фігури");
                return;
        }

        Console.WriteLine(shape.Draw());

        double area = shape.CalculateArea();
        Console.WriteLine($"Area: {area}");

        double perimeter = shape.CalculatePerimeter();
        Console.WriteLine($"Perimeter: {perimeter}");
    }

    private static Color getColor(string colorType)
    {
        switch (colorType)
        {
            case "red":
                return new RedColor();
            case "blue":
                return new BlueColor();
            case "green":
                return new GreenColor();
            default:
                throw new NotImplementedException();
        }
    }
}
