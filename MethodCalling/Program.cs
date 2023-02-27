using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] myDoubles = new double[10];
            GetUserDoubleValues(out myDoubles);

            Console.WriteLine("The array values are:");
            DisplayArray(myDoubles);

            GetAverage(myDoubles);
            GetMax(myDoubles);
            GetMin(myDoubles);
            GetMedian(myDoubles);
        }

        static void GetUserDoubleValues(out double[] values)
        {
            values = new double[10];
            Console.Write($"Enter 10 numbers: ");
            for (int i = 0; i < 10; i++)
            {

                string input = Console.ReadLine();

                double value;
                if (double.TryParse(input, out value))
                {
                    values[i] = value;
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a valid double value.");
                    i--;
                }
            }
        }

        static void DisplayArray(double[] values)
        {
            foreach (double value in values)
            {
                Console.Write("{value} ");
            }
            Console.WriteLine();
        }

        static void GetAverage(double[] values)
        {
            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }

            double average = sum / values.Length;

            Console.WriteLine("The average value of the array is: {average}");
        }

        static void GetMax(double[] values)
        {
            double max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            Console.WriteLine("The maximum value of the array is: {max}");
        }

        static void GetMin(double[] values)
        {
            double min = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }

            Console.WriteLine("The minimum value of the array is: {min}");
        }

        static void GetMedian(double[] values)
        {
            int length = values.Length;
            Array.Sort(values); 

            if (length % 2 == 0)
            {

                double middleIndex1 = (length / 2) - 1;
                double middleIndex2 = length / 2;
                double median = (values[(int)middleIndex1] + values[(int)middleIndex2]) / 2;
                Console.WriteLine("The median value of the array is: {median}");
            }
            else
            {

                double middleIndex = length / 2;
                double median = values[(int)middleIndex];
                Console.WriteLine("The median value of the array is: {median}");
            }
        }
    }
}