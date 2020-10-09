using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            Console.WriteLine("Введите координаты первой вершины: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            
            double perimetr = 0;
            
            perimetr += Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);
            perimetr += Math.Pow(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2), 0.5);
            perimetr += Math.Pow(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2), 0.5);
            
            Console.WriteLine("Периметр равен: " + Convert.ToString(perimetr));
            Console.ReadKey();
        }
    }
}
