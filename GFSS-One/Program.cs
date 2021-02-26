using System;

namespace GFSS_One
{
    class Program
    {
        static void Main(string[] args)
        {
            var ohmCalculator = new ECC_OhmCalculator(new ECC_ColorCodeParser());
            Console.WriteLine("Calculation Ohm Value for Brown-Black-Black");
            var ohm10 = ohmCalculator.CalculateOhmValue("Brown", "Black", "Black");
            Console.WriteLine($"Result: {ohm10}");
            Console.WriteLine("Calculation Ohm Value for Yellow-White-Black");
            var ohm39 = ohmCalculator.CalculateOhmValue("Yellow", "White", "Black");
            Console.WriteLine($"Result: {ohm39}");
            Console.WriteLine("Calculation Ohm  and Tolerance Value for Blue-White-Red");
            var bwrOT = ohmCalculator.CalculateOhmValueWithTolerance("Blue", "White", "Red");
            Console.WriteLine($"Result: Ohm: {bwrOT.ohm}, Tolerance: {bwrOT.tolerance}");
            Console.WriteLine("Calculation Ohm  and Tolerance Value for Blue-White-Red-Gold");
            var bwrgOT = ohmCalculator.CalculateOhmValueWithTolerance("Blue", "White", "Red", "Gold");
            Console.WriteLine($"Result: Ohm: {bwrgOT.ohm}, Tolerance: {bwrgOT.tolerance}");
            Console.ReadLine();
        }
    }
}
