namespace HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = 20000000000;
            double MudafieNazirliyi = budget * 0.2;
            double TexnologiyalarNazirliyi = budget * 0.1;
            double remainingBudget = budget - MudafieNazirliyi - TexnologiyalarNazirliyi;

            Console.WriteLine($"Budce : {budget}\n");
            Console.WriteLine($"Mudafie Nazirliyine : {MudafieNazirliyi}\n");
            Console.WriteLine($"Texnologiyalar Nazirliyine : {TexnologiyalarNazirliyi}\n");
            Console.WriteLine($"Yerde qalan budce : {remainingBudget}\n");





        }
    }
}