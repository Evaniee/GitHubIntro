using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubIntro
{
    public class Octagon : Regular2DShape     // Publically accessible Octagon class that inherits from the Regular2DShape class
    {
        public Octagon(double length) : base(length)
        {
        }

        public override double GetArea()
        {
            // Formula for the Area of an Octagon:
            // Area = 2 * ( 1 + sqrt(2) ) * n ^ 2
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(Length, 2);
        }
    }
}
