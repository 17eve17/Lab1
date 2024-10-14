using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;
    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }
    public double ConvertFromUAH(double amountUAH, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amountUAH / usdRate;
            case "EUR":
                return amountUAH / eurRate;
            case "PLN":
                return amountUAH / plnRate;
            default:
                throw new Exception("Невідома валюта!");
        }
    }
    public double ConvertToUAH(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount * usdRate;
            case "EUR":
                return amount * eurRate;
            case "PLN":
                return amount * plnRate;
            default:
                throw new Exception("Невідома валюта!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(41.23, 45.08, 10.50);
        Console.WriteLine("Оберіть тип операції:");
        Console.WriteLine("1. Конвертація з гривні в іноземну валюту");
        Console.WriteLine("2. Конвертація з іноземної валюти в гривню");

        int operationType;
        while (!int.TryParse(Console.ReadLine(), out operationType) || (operationType != 1 && operationType != 2))
        {
            Console.WriteLine("Будь ласка, введіть 1 або 2.");
        }
        if (operationType == 1)
        {
            Console.Write("Введіть кількість гривень: ");
            double amountUAH = double.Parse(Console.ReadLine());

            Console.Write("Оберіть валюту (USD, EUR, PLN): ");
            string currency = Console.ReadLine();

            double convertedAmount = converter.ConvertFromUAH(amountUAH, currency);
            Console.WriteLine($"Сума в {currency}: {convertedAmount}");
        }
        else if (operationType == 2)
        {
            Console.Write("Введіть кількість валюти: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Оберіть валюту (USD, EUR, PLN): ");
            string currency = Console.ReadLine();

            double convertedAmount = converter.ConvertToUAH(amount, currency);
            Console.WriteLine($"Сума в гривнях: {convertedAmount}");
        }
    }
}
