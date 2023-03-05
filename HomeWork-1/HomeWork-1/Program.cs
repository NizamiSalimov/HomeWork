namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float USD_RATE = 1.697f;
            float EUR_RATE = 1.817f;
            float RUB_RATE = 0.114f;
            Console.WriteLine("Amount (AZN) : ");
            float azn = float.Parse(Console.ReadLine());


            float usd = azn * USD_RATE;
            float eur = azn * EUR_RATE;
            float rub = azn * RUB_RATE;

            Console.WriteLine("ABŞ dolları (USD) :");
            Console.WriteLine(usd);

            Console.WriteLine("Avro (EUR) :");
            Console.WriteLine(eur);

            Console.WriteLine("Rusiya rublu (RUB) :");
            Console.WriteLine(rub);
        }
    }
}