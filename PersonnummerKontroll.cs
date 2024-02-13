using System;

namespace PersonnummerVerifiering
{
    public static class PersonnummerKontroll
    {
        public static bool ValideraPersonnummer(string personnummer)
        {
            // Kontrollerar så att personnummersinmatningen inte är null
            if (string.IsNullOrEmpty(personnummer))
            {
                Console.WriteLine("Personnumret är tomt.");
                return false;
            }
            
            // Kontrollera om personnumret har rätt längd.
            if (personnummer.Replace("-", "").Length != 10)
            {
                Console.WriteLine("Personnumret har fel längd.");
                return false;
            }

            // Kontrollera om alla tecken är siffror, bindestreck eller plus-tecken.
            foreach (char c in personnummer)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    Console.WriteLine("Personnumret innehåller ogiltiga tecken.");
                    return false;
                }
            }

            // Om personnumret är i formatet "ÅÅMMDDXXXX" eller "ÅÅMMDD-XXXX"
            if (personnummer.Length == 10 || personnummer.Length == 12)
            {
                int år = int.Parse(personnummer.Substring(0, 2));
                int månad = int.Parse(personnummer.Substring(2, 2));
                int dag = int.Parse(personnummer.Substring(4, 2));

                // Kontroll för år, månad och dag.
                if (år < 0 || månad < 1 || månad > 12 || dag < 1 || dag > DateTime.DaysInMonth(2000 + år % 100, månad))
                {
                    Console.WriteLine("Ogiltigt födelsedatum.");
                    return false;
                }
            }
            return true;
        }

        public static string HämtaKönFrånPersonnummer(string personnummer)
        {
            // Kontrollerar om personnumret är giltigt innan kön hämtas
            if (!ValideraPersonnummer(personnummer))
            {
                return "Ogiltigt personnummer";
            }

            // Hämtar de sista två siffrorna i personnumret
            int sistaSiffror = int.Parse(personnummer.Substring(personnummer.Length - 2));

            // Om de sista siffrorna är jämna returnera "Kvinna", annars "Man"
            return (sistaSiffror % 2 == 0) ? "Kvinna" : "Man";
        }
    }
}
