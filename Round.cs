using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_TEST_TASK
{
    public class Round 
    {
        private double radius;

        public Round(double _radius)
        {
            radius = _radius;
        }
        public double Radius { get { return radius; } }
        public void setRadius(double _radius)
        {
            this.radius = _radius;
        }

        public double square(Round round)
        {
            double square;
            square = 3.14 * round.radius  * round.radius;
            return square;
        }

    }
}
