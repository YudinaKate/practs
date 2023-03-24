using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA2
{
    class SolutionD
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double x1;
        private double x2;
        private double CalculateDiscr()
        {
            d = Math.Pow(b, 2) - 4 * a * c;
            return d;
        }
        void CalculateRoots()
        {
            this.d = CalculateDiscr();
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            } else if (d == 0) {
                x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1}");
            } else
            {
                Console.WriteLine("Не имеет действительных корней");
            }
        }
        public void GetRoots()
        {
            CalculateRoots();
        }
        public SolutionD(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SolutionD discr = new SolutionD(1, -70, 600);
            discr.GetRoots();
            Console.ReadKey(true);
        }
    }
}


