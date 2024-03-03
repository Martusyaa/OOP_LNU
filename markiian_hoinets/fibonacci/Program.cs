
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Program
{
    class WorkAround
    {
        private static void Main(string[] args)
        {
            const string pathPositionFile = @"F:\C#\FibonachiRecursive\FibonachiRecursive\FiboPositions.txt";
            const string pathTargetFile = @"F:\C#\\FibonachiRecursive\FibonachiRecursive\FiboTarget.txt";
            const string pathStepFile = @"F:\C#\FibonachiRecursive\FibonachiRecursive\StepFile.txt";

            string tempContent;

            if (!File.Exists(pathPositionFile) || !File.Exists(pathTargetFile) || !File.Exists(pathStepFile))
            {
                throw new FileNotFoundException("File not found");
            }

            // reading from file
            tempContent = File.ReadAllText(pathPositionFile);

            // split string to list of integers
            List<int> numbers = tempContent.Split(',').Select(Int32.Parse).ToList();

            // parse integer from file
            int target = Int32.Parse(File.ReadAllText(pathTargetFile));
            int step = Int32.Parse(File.ReadAllText(pathStepFile));

            Console.WriteLine("fibonachiLimits() executed");
            var rangeList = fibonachiLimits(numbers, target);
            PrintValues(rangeList);

            Console.WriteLine("fibonachiStep() executed");
            var stepList = fibonachiStep(numbers, step);
            PrintValues(stepList);
   
        }

        public static void PrintValues(List<int> limits)
        {
            foreach (int a in limits)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("N value step: " + limits.Count + "\n");
        }

        // 0,1,2,3 // 4
        public static List<int> fibonachiLimits(List<int> fiboList, int target)
        {
            List<int> limits = fiboList.ToList();
            int lastElement = limits.Count;
            int sum = limits[lastElement - 1] + limits[lastElement - 2];

            if (target > sum)
            {
                limits.Add(sum);
                return fibonachiLimits(limits, target);
            }

            return limits.ToList(); 
        }

        public static List<int> fibonachiStep(List<int> fiboList,int step)
        {
            List<int> fiboListTmp = fiboList.ToList();
            int lastElement = fiboListTmp.Count;

            if (lastElement == step)
            {
                return fiboListTmp;   
            }

            fiboListTmp.Add(fiboListTmp[lastElement - 1] + fiboListTmp[lastElement - 2]);

            return fibonachiStep(fiboListTmp, step).ToList();
        }
    }
}