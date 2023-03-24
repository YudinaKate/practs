using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA3_3
{
    internal class Program
    {
        class MyIntList
        {
            private List<int> numbersList = new List<int>();
            public int Sum
            {
                get
                {
                    return CalculateSum();
                }
            }
            public double Average
            {
                get
                {
                    return CalculateAverage();
                }
            }
            public void AddNumber(int number)
            {
                numbersList.Add(number);
            }
            public void RemoveNumber(int number)
            {
                numbersList.Remove(number);
            }
            private int CalculateSum()
            {
                int sum = 0;
                foreach (int number in numbersList)
                {
                    sum += number;
                }
                return sum;
            }
            private double CalculateAverage()
            {
                return Sum / (double)numbersList.Count;
            }
        }
        static void Main(string[] args)
        {
            MyIntList numbers = new MyIntList();
            numbers.AddNumber(45);
            numbers.AddNumber(27);
            numbers.AddNumber(23);
            numbers.AddNumber(28);
            numbers.AddNumber(8);
            Console.WriteLine(numbers.Sum);
            Console.WriteLine(numbers.Average);
            Console.ReadKey(true);
        }
    }
}
