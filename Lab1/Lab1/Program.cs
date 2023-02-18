using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MyFunc
    {
        public static void PrintArray(in int[] arr)
        {
            foreach (var el in arr)
                Console.Write("{0} ", el);

            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Statistic st1 = new Statistic(12, 21, 4, 6, 57);

            List<int> list = new List<int> { 12, 21, 4, 6, 547, 57 };
            Statistic st2 = new Statistic(list);

            Statistic st3 = new Statistic("1,   , 3 , 5,2");

            MyFunc.PrintArray(st1.GetData());
            MyFunc.PrintArray(st2.GetData());
            MyFunc.PrintArray(st3.GetData());

            Console.WriteLine("First Statistic:");
            Console.WriteLine("Sum: {0}", st1.SumSales());
            Console.WriteLine("Average: {0}", st1.AverageSales());
            Console.WriteLine("Count below average {0}", st1.MonthsSalesBelowAverage());
            Console.WriteLine("Count above average: {0}", st1.MonthsSalesAboveAverage());

            Console.Write("Max: ");
            MyFunc.PrintArray(st1.MaxSales());

            Console.Write("Min: ");
            MyFunc.PrintArray(st1.MinSales());

            Console.ReadKey();
        }
    }
}
