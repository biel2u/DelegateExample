using System;

namespace Delegates
{
    internal class Program
    {
        private delegate double CurrencyDelegate(int amount);

        private static void Main()
        {
            var currencyConverter = new CurrencyConverter();
            var currencyDelegate = new CurrencyDelegate(currencyConverter.DolarToZloty);
            var dolarExchangeRate = currencyDelegate(1);

            Console.WriteLine($"Obecny kurs dolara to: {dolarExchangeRate}");
            Console.WriteLine($"100 zł to: {currencyConverter.ZlotyToDolar(100)} USD");
            Console.ReadKey();
        }
    }
}
