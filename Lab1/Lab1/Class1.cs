using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Statistic
    {
        private int[] sales;

        public Statistic(params int[] array)
        {
            sales = new int[array.Length];
            Array.Copy(array, sales, array.Length);
        }

        public Statistic(List<int> list)
        {
            sales = list.ToArray();
        }

        public Statistic(String str)
        {
            string[] stringNumbers = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            sales = new int[stringNumbers.Length];
            try
            {
                for (int i = 0; i < sales.Length; i++)
                {
                    sales[i] = int.Parse(stringNumbers[i]);
                }
            }
            catch (Exception e)
            {
                Console.Write("Exeption: {0} in...", e.ToString());
                sales = new int[stringNumbers.Length];
            }
        }

        public int SumSales()
        {
            return sales.Sum();
        }

        public double AverageSales()
        {
            return (double)sales.Sum() / sales.Length;
        }

        public int MonthsSalesBelowAverage()
        {
            return sales.Where(x => x < (double)sales.Sum() / sales.Length).Count();
        }

        public int MonthsSalesAboveAverage()
        {
            return sales.Where(x => x > (double)sales.Sum() / sales.Length).Count();
        }

        public int[] MaxSales()
        {
            int maxSales = sales.Max();

            List<int> monthWithMaxSales = new List<int>();
            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] == maxSales)
                    monthWithMaxSales.Add(i);
            }

            return monthWithMaxSales.ToArray();
        }

        public int[] MinSales()
        {
            int minSales = sales.Max();

            List<int> monthWithMinSales = new List<int>();
            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] == minSales)
                    monthWithMinSales.Add(i+1);
            }

            return monthWithMinSales.ToArray();
        }

        public int[] GetData()
        {
            int[] arr = new int[sales.Length];
            Array.Copy(sales, arr, sales.Length);
            return arr;
        }

    }
}
