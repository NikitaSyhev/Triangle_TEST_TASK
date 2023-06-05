using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_TEST_TASK
{
    public class Triangle
    {
        private double side1;
        private double side2;
        private double side3;

       public Triangle(double _side1, double _side2, double _side3)
        {
            side1 = _side1;
            side2 = _side2;
            side3 = _side3;
        }
        public double Side1 { get { return side1; } }
        public double Side2 { get { return side2; } }
        public double Side3 { get { return side3; } }
        public void setSide1 (double _side1) 
        {
            this.side1 = _side1;
        }

        public void setSide2(double _side2)
        {
            this.side2 = _side2;
        }

        public void setSide3(double _side3)
        {
            this.side3 = _side3;
        }

        public double square(Triangle triangle)
        {
            double square;
            square = (triangle.side1 + triangle.side2 + triangle.side3) / 2;
            return square;
        }





    }
}