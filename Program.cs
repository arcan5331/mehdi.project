using System;
using System.Collections;
using System.Collections.Generic;

namespace mehdi
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new List<adad>();
            var tempx = new List<double>();
            var tempy = new List<double>();
            Console.WriteLine("Enter Count of Elements:");
            var count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine($"Enter {i+1} element for x:");
                tempx.Add(Convert.ToDouble(Console.ReadLine()));
                System.Console.WriteLine($"Enter {i+1} element for y:");
                tempy.Add(Convert.ToDouble(Console.ReadLine()));
            }
            for (int i = 0; i + 1 < count; i++)
            {
                test.Add(frstAdad(tempx[i], tempx[i + 1], tempy[i], tempy[i + 1]));
            }

            while (test.Count != 1)
            {
                test = nextlvl(test);
            }
            System.Console.WriteLine($"The Anser is {test[0].M} with root of {test[0].X1} and {test[0].X2}");




        }
        static adad frstAdad(double x1, double x2, double y1, double y2)
        {
            return new adad(x1, x2, (y2 - y1) / (x2 - x1));
        }
        static adad combine(adad A1, adad A2)
        {
            return new adad(A1.X1, A2.X2, (A2.M - A1.M) / (A2.X2 - A1.X1));
        }

        static List<adad> nextlvl(List<adad> clm)
        {
            var output = new List<adad>();
            for (int i = 0; i + 1 < clm.Count; i++)
            {
                output.Add(combine(clm[i], clm[i + 1]));
            }
            return output;
        }
    }


    public class adad
    {
        public adad() { }
        public adad(double x1, double x2, double m)
        {
            X1 = x1;
            X2 = x2;
            M = m;
        }
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double M { get; set; }


    }
}
