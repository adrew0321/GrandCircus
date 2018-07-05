using System;

namespace GCLab1P2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# console application to calculate the duration between two dates in Years,
               Months and Days. The user should enter two dates as input, then the program will show the
               result of the difference in time between these two dates. Show the difference in days, hours, and
               minutes*/

            bool repeat1 = true;
            while (repeat1)
            {

                DateTime userInput1 = new DateTime();
                DateTime userInput2 = new DateTime();


                //UserDate1
                bool repeat3 = true;
                while (repeat3)
                {
                    Console.WriteLine("Please insert your first date. Press the ENTER key to continue. (Example: xx/xx/xxxx)");
                    string input1 = Console.ReadLine();

                    //Exceptions
                    try
                    {
                        userInput1 = DateTime.Parse(input1);
                        repeat3 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Please use numerical digits when entering your date.");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Critical Error:" + e.Message);
                    }
                }

                Console.WriteLine("Your first date is: " + userInput1.ToLongDateString());
                Console.ReadLine();


                //UserDate2
                bool repeat4 = true;
                while (repeat4)
                {
                    Console.WriteLine("Please insert your second date. Press the ENTER key to continue. (Ex: xx/xx/xxxx)");
                    string input2 = Console.ReadLine();

                    //Exceptions
                    try
                    {
                        userInput2 = DateTime.Parse(input2);
                        repeat4 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Please use numerical digits when entering your date.");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Critical Error:" + e.Message);
                    }
                }

                Console.WriteLine("Your second date is: " + userInput2.ToLongDateString());
                Console.ReadLine();


                //Compares both UserInputs and displays the difference in time in Days, Hours, Minutes
                if (userInput2 > userInput1)
                {
                    TimeSpan differenceInTime = userInput2.Subtract(userInput1);
                    Console.WriteLine("The difference in time between these two dates are: " + differenceInTime.TotalDays + "Days, " + differenceInTime.TotalHours + "Hours, and " + differenceInTime.TotalMinutes + "Minutes. ");
                    Console.ReadLine();
                }
                else
                {
                    TimeSpan differenceInTime = userInput1.Subtract(userInput2);
                    Console.WriteLine("The difference in time between these two dates are: " + differenceInTime.TotalDays + "Days, " + differenceInTime.TotalHours + "Hours, and " + differenceInTime.TotalMinutes + "Minutes. ");
                    Console.ReadLine();
                }

                //Checks to see if User wants to run program again
                bool repeatError = true;
                while (repeatError)
                {
                    Console.WriteLine("Would you like to compare another set of dates? (Please enter Yes or No.)");
                    string userResponse = Console.ReadLine();

                    if (userResponse == "Yes" || userResponse == "YES" || userResponse == "yes")
                    {
                        repeat1 = true;
                        repeatError = false;
                    }
                    else if (userResponse == "No" || userResponse == "no" || userResponse == "NO")
                    {
                        repeat1 = false;
                        repeatError = false;
                        Console.WriteLine("Closing application... Press ENTER key to continue.");
                    }
                    else
                    {
                        Console.WriteLine("Error: Please respond with Yes or No.");
                        repeatError = true;
                    }
                }

            }
        }
    }
}
