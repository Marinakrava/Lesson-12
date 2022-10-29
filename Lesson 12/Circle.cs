using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    static class Circle
    {
        static public double GetSquare(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public string GetCoordinates(double x, double y,double r)
        {
            double hypotinuse = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));
            if (hypotinuse <= r)
                return "Точка принадлежит кругу";
            else
            {
                return "Точка не принадлежит кругу";
            }
                
        }
    }
}
