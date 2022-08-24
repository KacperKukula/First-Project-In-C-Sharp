using System;

namespace First_Project_In_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPodaj datę swoich urodzin");
            Console.Write("\nDzień: ");
            int birthDay = int.Parse(Console.ReadLine());
            Console.WriteLine("\nMiesiąc: ");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("\nRok: ");
            int birthYear = int.Parse(Console.ReadLine());

            DateTime NowaDays = DateTime.Now;
            int SumOfDays = 0;
            SumOfDays += Math.Abs(NowaDays.Day-birthDay);
            SumOfDays += Math.Abs((NowaDays.Month-birthMonth)*30);
            SumOfDays += Math.Abs((NowaDays.Year-birthYear)*356);

            if(SumOfDays==0) 
                Console.WriteLine("Urodziłeś się dzisiaj! Gugu gaga!");
            else 
                Console.WriteLine("Liczba dni: "+SumOfDays);
        }
    }
}
