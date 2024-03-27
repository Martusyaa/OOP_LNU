using System;

public abstract class Figure
{
	protected Color color;
	public abstract string Name();
	public abstract double Perimeter();
	public abstract double Area();
	public Figure( Color color)
	{
		this.color = color;
	}



	public void Print()
	{

    
            Console.WriteLine("Name: " + Name());
            try
            {
                Console.WriteLine("Perimeter: " + Perimeter());
                Console.WriteLine("Area: " + Area());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("Color: " + color.Draw());
    

        //Console.WriteLine("\nName: " + Name());
        //Console.WriteLine("Perimeter: " + Perimeter());
        //Console.WriteLine("Area: " + Area());
        //Console.WriteLine("Color: " + color.Draw());
    }
}
