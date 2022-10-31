using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceSquareM = double.Parse(Console.ReadLine()) * 7.61;
            double discount = priceSquareM * 0.18;
            double finalPrice = priceSquareM - discount;
            Console.WriteLine($"The final price is:{finalPrice} lv.");
            Console.WriteLine($"The discount is:{discount} lv.");
        }
    }
}
