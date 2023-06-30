// C# using switch statement.
using System;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (true)
            {
                int res;
                string welcome = "Hi, User! \nLet us help you do math easy. " +
                    "\nINSTRUCTION:Press enter after each input to continue with the calculations. Lookout for hints. " +
                    "\nWhat's your name?";

                foreach (char c in welcome)
                {

                    Console.Write(c);

                    System.Threading.Thread.Sleep(50);
                }

                Console.WriteLine();
                string Username = Console.ReadLine();


                string sign = " " + Username + " " + ", please insert the mathematical sign you would like to use for this exercise." +
                    " NB: ONLY ONE SIGN CAN BE CHOSEN AT ONCE \n \"Hint: (/ DIVISION,+ ADDITION,- SUBTRATION,* MULTIPLICATION)";
                foreach (char c in sign)
                {

                    Console.Write(c);

                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();
                string symbol = Console.ReadLine();




                string first = "Enter first value:";
                foreach (char c in first)
                {

                    Console.Write(c);

                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();
                int num1 = Convert.ToInt32(Console.ReadLine());



                string second = "Enter seconod value:";
                foreach (char c in second)
                {

                    Console.Write(c);

                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine(Username + " " + "your Answer for the sum is:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine(Username + " " + "the answer is:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine(Username + " " + "your answer is:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine(Username + " " + "your answer is:" + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;

                }
                Console.ReadLine();

                string end = "CALCULATION COMPLETE!";
                foreach (char c in end)
                {

                    Console.Write(c);

                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();

                string option = " " + Username + " " + ",  do you want to continue with more calculations(y/n):";
                foreach (char c in option)
                {

                    Console.Write(c);

                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();


                value = Console.ReadLine();





                if (value == "n" || value == "N")
                {
                    Console.WriteLine("Thank you" + " " + Username);
                    Console.WriteLine("Press anykey to exit");
                    Console.ReadLine();
                    Console.WriteLine("Press Enter to exit");
                    break;
                }


            }

        }
    }

}
