using System;

namespace Delegates
{
    public class CurrencyConverter
    {
        public double ZlotyToDolar (int amount)
        {
            const double exchangeRate = 0.29;
            var result = amount * exchangeRate;

            return result;
        }

        public double DolarToZloty(int amount)
        {
            const double exchangeRate = 3.41;
            var result = amount * exchangeRate;

            return result;
        }

        public string Pay(int amount)
        {
            var result = $"Zapłacono: {amount} zł.";

            return string.Format(result);
        }

        public void DisplayValueInCurrencyFormat(int amount)
        {
            var amountToCurrencyFormat = amount.ToString("C2");
            Console.WriteLine($"Pozostało ci {amountToCurrencyFormat} na koncie");
        } 
    }
}
