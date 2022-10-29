using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
           
            double square = Circle.GetSquare(r);
            Console.WriteLine("Площадь окружности = {0:.00}", square);
            
            double length = Circle.GetLength(r);
            Console.WriteLine("Длина окружности = {0:.00}", length);

            Console.WriteLine("Введите координаты точки");
            double x = Convert.ToInt32(Console.ReadLine());
            double y= Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine(Circle.GetCoordinates(x,y,r));

            Console.ReadKey();
        }
    }
}
