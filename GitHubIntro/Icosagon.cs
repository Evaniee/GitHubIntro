using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubIntro
{
    public class Icosagon : Regular2DShape
    {
        public Icosagon(double length) : base(length)
        {
        }

        public override double GetArea()
        {
            // Formula for the Area of an Octagon
            // Area = 5 * n^2 * (1 + sqrt(5) + sqrt(5 + 2 * sqrt(5))
            return 5 * Math.Pow(_length, 2) * (1 + Math.Sqrt(5) + Math.Sqrt(5 + (2 * Math.Sqrt(5))));
        }
    }
}
