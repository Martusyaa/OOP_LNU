using System;

namespace fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int steps;
            StreamReader file2 = new StreamReader("File2.txt");
            steps = Convert.ToInt32(file2.ReadLine());
            file2.Close();

            int limite;
            StreamReader file3 = new StreamReader("TextFile2.txt");
            limite = Convert.ToInt32(file3.ReadLine());
            file3.Close();

            int a, b;
            StreamReader file1 = new StreamReader("File1.txt");
            a = Convert.ToInt32(file1.ReadLine());
            b = Convert.ToInt32(file1.ReadLine());
            file1.Close();

            int c, d;
            StreamReader file4 = new StreamReader("TextFile1.txt");
            c = Convert.ToInt32(file4.ReadLine());
            d = Convert.ToInt32(file4.ReadLine());
            file4.Close();
            List<double> listt = new List<double>() { c, d };
            Console.WriteLine("Ряд Фібоначчі:");
            Fibonacci.steps(steps, listt).ForEach(x => Console.Write(x + " "));

            Console.WriteLine();

            Console.WriteLine("Кількість кроків:");
            Console.WriteLine(steps);


            Console.WriteLine();

            Console.WriteLine("Ряд Фібоначчі:");
            Fibonacci.limit(limite, steps, listt).ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            Console.WriteLine("Ліміт:");
            Console.WriteLine(limite);
        }
    }
}