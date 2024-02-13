using System;

namespace PersonnummerVerifiering
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv in ditt personnummer (ÅÅMMDD-XXXX): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (PersonnummerKontroll.ValideraPersonnummer(input))
            {
                Console.WriteLine("Personnumret är giltigt.");

                string kon = PersonnummerKontroll.HämtaKönFrånPersonnummer(input);
                Console.WriteLine($"Kön: {kon}");
            }
            else
            {
                Console.WriteLine("Ogiltigt personnummer. Kontrollera att formatet är korrekt (ÅÅMMDD-XXXX) och att födelsedatumet och kontrollsiffran är giltiga.");
            }

            Console.ReadLine();
        }
    }
}
