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
            Console.Write("\nPrzyjęto liczbę: ");
            WriteColor(userNum.ToString(), "green");
            Console.WriteLine("\n");

            int min = 8, max = 65, checkNum;
            Random r = new Random();

            for(int i=0; i<64; i++) {

                checkNum = r.Next(min, max);

                Console.Write($"Step {i}: --> ");
                if(userNum == checkNum) {
                    Console.Write($"{userNum} = {checkNum} ");
                    WriteColor("Znalazłem!", "green");
                    Console.Write("\n\n");
                    return 1;
                }
                else if(userNum > checkNum) {
                    Console.Write($"{userNum} > {checkNum} ");
                    WriteColor("Mój numer mniejszy", "red");
                    Console.Write("\n");
                    min = checkNum;
                }
                else if(userNum < checkNum) {
                    Console.Write($"{userNum} < {checkNum} ");
                    WriteColor("Mój numer większy", "red");
                    Console.Write("\n");
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(value.PadRight(Console.WindowWidth - 1));
                    break;
                default:
                    Console.Write(value);
                    break;
            }

	        Console.ResetColor();
        }
    }
}
