using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 {
    internal class Program {
        static void Main(string[] args) {

            // first name               string  0
            // last name                string  1
            // street                   string  2
            // house number             int     3
            // apartment number         int     4
            // zip code                 int     5
            // city                     string  6

            // questions to be asked as an array
            String[] questions = {
                "Please enter your first name: ",
                "Please enter your last name: ",
                "Please enter your street: ",
                "Please enter your house number: ",
                "Please enter your apartment number: ",
                "Please enter your zip code: ", 
                "Please enter your city: "    
            };

            String[] answers = new string[7];

            // variables to take inputs
            String readLine;
            int num;

            // loop till every question has been asked
            for (int i = 0; i < questions.Length; i++) {

                // loop till current question has been answered
                while (true) {
                    // ask question
                    Console.Write(questions[i]);

                    // get answer
                    readLine = Console.ReadLine();

                    // re ask for non numerical input on number question
                    if ((i >= 3 && i <= 5) && !int.TryParse(readLine.ToString(), out num)) continue;
                                        
                    // save answer
                    answers[i] = readLine;
                    break;
                }
            }
            // output formated answer
            Console.WriteLine($"{answers[0]} {answers[1]}\nSt. {answers[2]} {answers[3]}/{answers[4]}\n{answers[5]} {answers[6]}");
        }
    }
}
