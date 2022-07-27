using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__Static_Classses_and_Neasted_Classes_
{
   static class Calculator
   {
        public static double Multiply(double p1, double p2)
        {
            return p1 * p2;
        }

        public static double Devision(double p1, double p2)
        {
            return p1 / p2;
        }

        public static double Substraction(double p1, double p2)
        {
            return p1 - p2;
        }

        public static double Addition(double p1, double p2)
        {
            return p1 + p2;
        }
   }
}
