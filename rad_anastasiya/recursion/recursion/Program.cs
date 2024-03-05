using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepCount;
            using (StreamReader readtext = new StreamReader(@"D:\nanaka\унік прога\recursion\recursion\steps.txt"))
            {
                stepCount = int.Parse(readtext.ReadLine());
            }

            double borderCount;
            using (StreamReader readtext = new StreamReader(@"D:\nanaka\унік прога\recursion\recursion\border.txt"))
            {
                borderCount = double.Parse(readtext.ReadLine());
            }

            List<double> dataForBorder;

            List<double> data;
            using (StreamReader readtext = new StreamReader(@"D:\nanaka\унік прога\recursion\recursion\data.txt"))
            {
                data = readtext.ReadLine().Split().Select(i => double.Parse(i)).ToList();
                dataForBorder = new List<double>(data);
            }


            List<double> stepsResult = Fibonacci.steps(stepCount, data);
            Console.WriteLine("step algorithm");
            stepsResult.ForEach(x => { Console.Write(x + ", "); });

            Duo borderResult = Fibonacci.border(borderCount, dataForBorder);
            Console.WriteLine("\nborder algorithm");
            borderResult.doubles.ForEach(x => { Console.Write(x + ", "); });
            Console.WriteLine("\nsteps: " + borderResult.steps);
        }
    }
}



