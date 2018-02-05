using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleTest1
{
    public class TriangleHandler
    {

        public enum TriangleType
        {
            Error,
            Equilateral,
            Isoceles,
            Scalene

        }

        public static TriangleType CalculateTriangleType(int a, int b, int c)
        {
            
            if (!(a > 0 && b > 0 && c > 0))
            {
                return TriangleType.Error;
            }
            else if (a==b && b == c)
            {
                return TriangleType.Equilateral;
            }
            else if (a == b || b == c || a == c)
            {
                return TriangleType.Isoceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }
    }
}
