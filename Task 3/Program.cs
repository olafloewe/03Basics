using System;

namespace Task_3 {
    internal class Program {
        static void Main(string[] args) {

            String readLine;
            Random rnd = new Random();

            // loop till user breaks loop
            while (true) {
                // ask question
                Console.Write("Do you want to print a random number between 0 and 100? input: (Y/N) ");

                // get user answer and re ask on invalid input
                readLine = Console.ReadLine();
                if (readLine.ToLower() != "y" && readLine.ToLower() != "n") continue;

                // user breaks loop
                if(readLine.ToLower() == "n") break;

                Console.WriteLine(rnd.Next(0,100));
            }
        }
    }
}