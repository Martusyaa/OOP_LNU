namespace Bridge
{
    class Program
    {
        static void Main()
        {
            try
            {
                string filePath = "input.txt";
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] tokens = line.Split(',');

                    if (tokens.Length < 2)
                    {
                        Console.WriteLine($"Некоректний формат даних: {line}");
                        continue;
                    }

                    string figureType = tokens[0].Trim();
                    string color = tokens[1].Trim();

                    if (figureType.Equals("Circle", StringComparison.OrdinalIgnoreCase))
                    {
                        if (tokens.Length < 3)
                        {
                            Console.WriteLine($"Недостатньо даних для кола: {line}");
                            continue;
                        }
                        if (!double.TryParse(tokens[2].Trim(), out double radius))
                        {
                            Console.WriteLine($"Неправильний формат радіуса: {line}");
                            continue;
                        }
                        Circle circle = new Circle(GetColor(color), radius);
                        Console.WriteLine($"Circle: Color: {color}, Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");
                    }
                    else if (figureType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
                    {
                        if (tokens.Length < 4)
                        {
                            Console.WriteLine($"Недостатньо даних для прямокутника: {line}");
                            continue;
                        }
                        if (!double.TryParse(tokens[2].Trim(), out double width) || !double.TryParse(tokens[3].Trim(), out double height))
                        {
                            Console.WriteLine($"Неправильний формат ширини або висоти: {line}");
                            continue;
                        }
                        Rectangle rectangle = new Rectangle(GetColor(color), width, height);
                        Console.WriteLine($"Rectangle: Color: {color},Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
                    }
                    else if (figureType.Equals("Square", StringComparison.OrdinalIgnoreCase))
                    {
                        if (tokens.Length < 3)
                        {
                            Console.WriteLine($"Недостатньо даних для квадрата: {line}");
                            continue;
                        }
                        if (!double.TryParse(tokens[2].Trim(), out double sideLength))
                        {
                            Console.WriteLine($"Неправильний формат довжини сторони: {line}");
                            continue;
                        }
                        Square square = new Square(GetColor(color), sideLength);
                        Console.WriteLine($"Square: Color: {color}, Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
                    }
                    else
                    {
                        Console.WriteLine($"Невідомий тип фігури: {figureType}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }

        static IColor GetColor(string color)
        {
            switch (color.ToLower())
            {
                case "red":
                    return new RedColor();
                case "green":
                    return new GreenColor();
                default:
                    throw new ArgumentException($"Невідомий колір: {color}");
            }
        }
    }
}
