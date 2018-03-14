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
    }
}
