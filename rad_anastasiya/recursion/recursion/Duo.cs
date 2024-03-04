using System.Collections.Generic;

namespace recursion
{
    public class Duo
    {
        public int steps { get; }

        public List<double> doubles { get; }

        public Duo(int steps, List<double> doubles) 
        {
            this.steps = steps;
            this.doubles = doubles;

        }
    }
}
