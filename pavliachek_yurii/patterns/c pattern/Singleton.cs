using System;
using System.Runtime.Intrinsics.Arm;

public class Car
{
    public string brand { get; set; }
    public string model { get; set; }
    public double speed { get; set; }

    public Car(string brand, string model, double speed)
    {
        this.brand = brand;
        this.model = model;
        this.speed = speed;
    }
    public void Increase(double car_speed)
    {
        speed += car_speed;
    }
    public void Decrease(double car_speed)
    {
        if(speed <= car_speed)
        {
            throw new ArgumentException("Speed can't be less than 0");
        }
        speed -= car_speed;
    }
    public void Print()
    {
        Console.WriteLine($"Brand: {brand}, Model: {model}, Speed: {speed}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", "X5", 0);
        car.Print();

        car.Increase(20);
        car.Print();

        car.Decrease(10);
        car.Print();
    }
}
