// See https://aka.ms/new-console-template for more information
using System;
using AljabarLibrary;

namespace tpmodul11_1302223148
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] persamaan1 = { 1, -3, -10 };
            double[] akar1 = Aljabar.AkarPersamaanKuadrat(persamaan1); 
            Console.WriteLine("Akar persamaan kuadrat:");
            Console.WriteLine("Output: {" + string.Join(", ", akar1) + "}"); 

            double[] persamaan2 = { 2, -3 };
            double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaan2);
            Console.WriteLine("\nHasil kuadrat dari persamaan berpangkat 1:");
            Console.WriteLine("Output: {" + string.Join(", ", hasilKuadrat) + "}"); 
        }
 
    }

}