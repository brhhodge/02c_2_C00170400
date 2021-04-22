// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02C_2

using System;

namespace _02c_2_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {

            Dirt[] samples = new Dirt[10000];
            PopulateArray(samples);

            Console.WriteLine("Total sand in all samples: " + GetTotalSand(samples) + " grams"); // Method uses expression bodied lambda method
            Console.WriteLine("Total clay in all samples: " + GetTotalClay(samples) + " grams"); // Method uses expression bodied lambda method
 
            Console.WriteLine("Average sand per sample: " + GetAverageSand(samples) + " grams");
            Console.WriteLine("Average clay per sample: " + GetAverageClay(samples) + " grams");

        }

        public static void PopulateArray(Dirt[] d)
        {
            Random r = new Random();
            double totalSand = 0;
            double totalClay = 0;
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Dirt(r.NextDouble()*100, r.NextDouble()*100);

                totalSand += d[i].GetSand();
                totalClay += d[i].GetSand();

            }
        }


         static double GetTotalSand(Dirt[] dirt)
        {

            Func<Dirt[], double> totalSand = (Dirt[] d) => 
            {
                double SandTotal = 0;
                for (int i = 0; i < d.Length; i++)
                    SandTotal += d[i].GetSand();

                return SandTotal;
            };
            return totalSand(dirt);

        }

        static double GetTotalClay(Dirt[] dirt)
        {

            Func<Dirt[], double> totalClay = (Dirt[] d) => 
            {
                double ClayTotal = 0;
                for (int i = 0; i < d.Length; i++)
                    ClayTotal += d[i].GetClay();

                return ClayTotal;
            };
            return totalClay(dirt);

        }
        static double GetAverageSand(Dirt[] d)
        {
            double SandTotal = 0;
            for (int i = 0; i < d.Length; i++)
                SandTotal += d[i].GetSand();
            
            return SandTotal / d.Length;
        } 

        static double GetAverageClay(Dirt[] di)
        {
            double ClayTotal = 0;
            for (int i = 0; i < di.Length; i++)
                ClayTotal += di[i].GetClay();

            return ClayTotal / di.Length;
        }

    }
}
