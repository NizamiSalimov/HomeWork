namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adidas ayaqqabılarının məlumatları
            string adidas = "Adidas";
            int adidasCount = 4;
            int adidasPrice = 200;

            // Gucci ayaqqabılarının məlumatları
            string gucci = "Gucci";
            int gucciCount = 2;
            int gucciPrice = 1000;

            // Nike ayaqqabılarının məlumatları
            string nike = "Nike";
            int nikeCount = 1;
            int nikePrice = 150;

            // Hesablama və çap etmə
            int total = adidasCount * adidasPrice + gucciCount * gucciPrice + nikeCount * nikePrice;

            Console.WriteLine("Firma :");
            Console.WriteLine(adidas);
            Console.WriteLine("Ayaqqabi sayi :");
            Console.WriteLine(adidasCount);
            Console.WriteLine("Birinin qiymeti ($) :");
            Console.WriteLine(adidasPrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($) :");
            Console.WriteLine(adidasCount * adidasPrice);
            Console.WriteLine();

            Console.WriteLine("Firma :");
            Console.WriteLine(gucci);
            Console.WriteLine("Ayaqqabi sayi :");
            Console.WriteLine(gucciCount);
            Console.WriteLine("Birinin qiymeti ($) :");
            Console.WriteLine(gucciPrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($) :");
            Console.WriteLine(gucciCount * gucciPrice);
            Console.WriteLine();

            Console.WriteLine("Firma :");
            Console.WriteLine(nike);
            Console.WriteLine("Ayaqqabi sayi :");
            Console.WriteLine(nikeCount);
            Console.WriteLine("Birinin qiymeti ($) :");
            Console.WriteLine(nikePrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($) :");
            Console.WriteLine(nikeCount * nikePrice);
            Console.WriteLine();

            Console.WriteLine("Umumi hesablanan mebleg ($) :");
            Console.WriteLine(total);
        }
    }
}