using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci serisinin derinliğini giriniz:");
            int lenght = Convert.ToInt32(Console.ReadLine());

            fibonacciCalculator f = new fibonacciCalculator();
            avarageCalculator a = new avarageCalculator();

            int[] fibonacciSeries = f.CalculateFibonacciSeries(lenght);

            foreach (var item in fibonacciSeries)
            {
                Console.WriteLine(item + " ");
            }

            double avarageResult = a.CalculateAvarage(fibonacciSeries);
            Console.WriteLine(" \n Girilen derinlikteki fibonacci serisinin ortalaması: " + avarageResult);
        }
    }
}
