using System;

namespace First_Project_In_C_Sharp
{
    class Program
    {
        static int Main(string[] args)
        {
            int userNum = 0;
            while(userNum < 8 || userNum > 64) {
                Console.Write("\nPodaj liczbe (od 8 do 64 włącznie):");
                userNum = int.Parse(Console.ReadLine());
            }
            Console.Write("\nPrzyjęto liczbę ");
            WriteColor(String.ToString(userNum), "green");
            Console.WriteLine("\n");

            int min = 8, max = 65, checkNum;
            Random r = new Random();

            for(int i=0; i<64; i++) {

                checkNum = r.Next(min, max);

                Console.Write($"Step {i}: --> ");
                if(userNum == checkNum) {
                    Console.WriteLine($"{userNum} = {checkNum}, Zgadłem!\n");
                    return 1;
                }
                else if(userNum > checkNum) {
                    Console.WriteLine($"{userNum} > {checkNum}, Mój numer mniejszy");
                    min = checkNum;
                }
                else if(userNum < checkNum) {
                    Console.WriteLine($"{userNum} < {checkNum}, Mój numer większy");
                    max = checkNum;
                }
            }
            Console.WriteLine("System Timeout");
            return 0;
        }

        static void WriteColor(string value, string color)
        {
	        //
	        // This method writes an entire line to the console with the string.
	        //
            //Console.BackgroundColor = ConsoleColor.Green; //<--background 
            switch (color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(value.PadRight(Console.WindowWidth - 1));
                    break;
                case "red":
                    break;
            }

	        Console.ResetColor();
        }
    }
}
