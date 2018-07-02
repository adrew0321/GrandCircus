using System;

namespace GCLabP1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat1 = true;

            while (repeat1)
            {
                int user1Value1 = 0;
                int user1Value2 = 0;
                int user1Value3 = 0;


                //User Value 1
                bool repeat2 = true;
                while (repeat2)
                {
                    Console.WriteLine("Please enter your first digit. Press the ENTER key to Continue.");

                    //UserInput1
                    string userInput1 = Console.ReadLine();

                    try
                    {
                        user1Value1 = int.Parse(userInput1);
                        repeat2 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Please insert a numerical digit");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An unexpected error occurred.");
                    }
                }

                //UserInput2
                bool repeat3 = true;
                while (repeat3)
                {
                    Console.WriteLine("Please enter your second digit. Press the ENTER key to Continue.");
                    string userInput2 = Console.ReadLine();

                    try
                    {
                        user1Value2 = int.Parse(userInput2);
                        repeat3 = false;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Please insert a numerical digit");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An unexpected error occurred.");
                    }
                }


                //UserInput3
                bool repeat4 = true;
                while (repeat4)
                {
                    Console.WriteLine("Please enter your third digit. Press the ENTER key to Continue.");
                    string userInput3 = Console.ReadLine();

                    try
                    {
                        user1Value3 = int.Parse(userInput3);
                        repeat4 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Please insert a numerical digit");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An unexpected error occurred.");
                    }

                }

                int[] totalValue1 = { user1Value1, user1Value2, user1Value3 };

                Console.WriteLine("Your first total value is {0}{1}{2}. Press the ENTER key to Continue",
                    user1Value1, user1Value2, user1Value3);
                Console.ReadLine();

                //User2
                int user2Value1 = 0;
                int user2Value2 = 0;
                int user2Value3 = 0;


                bool repeat5 = true;
                while (repeat5)
                {
                    //UserInput4
                    Console.WriteLine("Please enter your first digit. Press the ENTER key to Continue.");
                    string userInput4 = Console.ReadLine();

                    try
                    {
                        user2Value1 = int.Parse(userInput4);
                        repeat5 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Please insert a numerical digit");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An unexpected error occurred.");
                    }

                }

                bool repeat6 = true;
                while (repeat6)
                {
                    //UserInput5
                    Console.WriteLine("Please enter your second digit. Press the ENTER key to Continue.");
                    string userInput5 = Console.ReadLine();
                    try
                    {
                        user2Value2 = int.Parse(userInput5);
                        repeat6 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Please insert a numerical digit");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An unexpected error occcured.");
                    }

                }

                bool repeat7 = true;
                while (repeat7)
                {

                    //UserInput6
                    Console.WriteLine("Please enter your third digit. Press the ENTER key to Continue.");
                    string userInput6 = Console.ReadLine();
                    try
                    {
                        user2Value3 = int.Parse(userInput6);
                        repeat7 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Please insert a numerical digit");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An unexpected error occcured.");
                    }

                }
                int[] totalValue2 = { user2Value1, user2Value2, user2Value3 };

                Console.WriteLine("Your second total value is {0}{1}{2}. Press the ENTER key to Continue.", user2Value1, user2Value2, user2Value3);
                Console.ReadLine();


                //Sum of User 1 and 2 TotalValues
                int sumOfUsersValue1 = Add(totalValue1[0], totalValue2[0]);
                int sumOfUsersValue2 = Add(totalValue1[1], totalValue2[1]);
                int sumOfUsersValue3 = Add(totalValue1[2], totalValue2[2]);


                //Checks if Sum of Values equal
                if (sumOfUsersValue1 == sumOfUsersValue2)
                {
                    if (sumOfUsersValue2 == sumOfUsersValue3)
                    {
                        Console.WriteLine("Outstanding! Your total values are equal. Press the Enter key to Continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately, your total values do not equal.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Unfortunately, your total values do not equal. Press the ENTER key to Continue");
                    Console.ReadLine();
                }


                Console.WriteLine("Would you like to run the program again? (Please enter Yes or No)");
                string userResponse = Console.ReadLine();

                if (userResponse == "yes" || userResponse == "YES" || userResponse == "Yes")
                {
                    repeat1 = true;
                }
                else if (userResponse == "No" || userResponse == "NO" || userResponse == "no")
                {
                    repeat1 = false;
                }
                else
                {
                    Console.WriteLine("Critcal Error: Progam shutting down...");
                    repeat1 = false;
                }
            }
        }
        private static int Add(int x, int y)
        {
            int answer = x + y;
            return answer;
        }

    }



}

