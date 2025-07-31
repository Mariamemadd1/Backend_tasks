using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace QuizGame
{

    internal class Program
    {
        static short count = 0;
        static void Main(string[] args)
        {
            //Quiz Game
            //5 questions
            //user input his answers 
            //when finished -> show score & correct answers

            Console.WriteLine("------------------------- Quick Health Quiz Game ! -------------------------");
            string[] Questions = { 
                "1. How much water should an average adult drink per day?",
                "2. What’s the best time to drink coffee to avoid crashing later?",
                "3. How often should you change your toothbrush?",
                "4. What’s the ideal screen break time rule to protect your eyes?",
                "5. Which food is highest in fiber? (Lowers cholesterol)"
            };

            string[][] choices = new string[5][];
            choices[0] = new string[] { "A) 1 liter", "B) 1.5 liters", "C) 2–3 liters", "D) 5 liters" };
            choices[1] = new string[] {"A) Right after waking up","B) Between 9:30 AM – 11:30 AM","C) Late afternoon","D) Before bed"};
            choices[2] = new string[] { "A) Once a year", "B) Every 3–4 months", "C) Only if the bristles are falling", "D) Every month" };
            choices[3] = new string[] { "A) 10 seconds every 10 minutes", "B) 20 seconds every 20 minutes", "C) 30 seconds every 30 minutes", "D) No need for breaks" };
            choices[4] = new string[] { "A) White rice", "B) Chicken", "C) Lentils", "D) Cheese" };

            string [] ans = {"C", "B" ,"B" , "B" ,"C"};

            for (int i = 0;i<Questions.Length;i++)
            {
                Console.WriteLine(Questions[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(choices[i][j]);
                }
                try
                {
                    string userInput = Console.ReadLine();
                    if (!correctAns(userInput, ans[i]))
                    {
                        Console.WriteLine($"Incorrect Answer , Correct is {ans[i]}");
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("----------------------------------");

            }
            showScore(count);
        }

        static bool correctAns(string userInput, string correctAns)
        {   if(string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Please Enter Your Answer");
            }
            else if (userInput.ToUpper() == correctAns)
                {
                    count++;
                    return true;
                }
            else return false;
            
        }

        static void showScore(short cnt)
        {
            Console.WriteLine($"You Scored {cnt} out of 5 " );
            if (cnt >= 3)
            {
                Console.WriteLine("Great Work ! Your health knowledge is on point ");
            }
            else
            {
                Console.WriteLine("Oops! Not all answers were correct \n Your health matters, so keep learning little by little");
            } 
        }
    }
}
