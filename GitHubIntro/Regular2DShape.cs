using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubIntro
{
    public abstract class Regular2DShape
    {
        protected double _length;        // Length of a single side

        /// <summary>
        /// Length of a single side
        /// </summary>
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        /// A regular 2D shape, all sides are the same length
        /// </summary>
        /// <param name="length">Length of a single side</param>
        public Regular2DShape(double length) { }

        /// <summary>
        /// Get the Area of the shape
        /// </summary>
        /// <returns>Area of the shape</returns>
        public abstract double GetArea();
    }
}
