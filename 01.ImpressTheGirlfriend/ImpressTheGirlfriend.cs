namespace _01.ImpressTheGirlfriend
{
    using System;

    public static class ImpressTheGirlfriend
    {
        private static double RubToLev = 0.035;
        private static double UsdToLev = 1.5;
        private static double EurToLev = 1.95;

        public static void Main()
        {
            var russianPrice = Math.Ceiling(uint.Parse(Console.ReadLine()) * RubToLev);
            var usPrice = Math.Ceiling(uint.Parse(Console.ReadLine()) * UsdToLev);
            var euroPrice = Math.Ceiling(uint.Parse(Console.ReadLine()) * EurToLev);
            var bundlePrice = Math.Ceiling(uint.Parse(Console.ReadLine()) / 2d);
            var bgPrice = double.Parse(Console.ReadLine());

            var mostExpensivePrice = Math.Max(russianPrice,
                Math.Max(usPrice,
                    Math.Max(euroPrice,
                        Math.Max(bundlePrice,
                            bgPrice))));

            Console.WriteLine($"{mostExpensivePrice:F2}");
        }
    }
}