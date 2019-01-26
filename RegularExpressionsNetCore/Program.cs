using System;
using System.Text.RegularExpressions;

namespace RegularExpressionsNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceso iniciado.");
            
            System.IO.StreamReader file = new System.IO.StreamReader(@"..\results games.csv");

            string line;
            int totalLines = 0;
            int totalMatches = 0;
            //Regex regex = new Regex(@"Mexico");
            // Regex regex = new Regex(@"^2011\-.*$"); //AllGamesOnYear2011
            Regex regex = new Regex(@"^2011\-.*[zk].*$"); //AllGamesOnYear2011WithLetterZorK
            while ((line = file.ReadLine()) != null)
            {
                Match match = regex.Match(line);
                if (match.Success)
                {
                    Console.WriteLine(line);
                    totalMatches++;
                }
                totalLines ++;
            }
            Console.WriteLine($"Total lines: {totalLines}");
            Console.WriteLine($"Total matches: {totalMatches}");
            Console.WriteLine("Proceso terminado.");
        }
    }
}
