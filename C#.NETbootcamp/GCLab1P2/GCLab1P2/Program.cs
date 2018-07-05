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

                //UserDate1
                Console.WriteLine("Please insert your first date. Press the ENTER key to continue. (Example: xx/xx/xxxx)");
                DateTime userInput1 = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Your first date is: " + userInput1.ToLongDateString());
                Console.ReadLine();


                //UserDate2
                Console.WriteLine("Please insert your second date. Press the ENTER key to continue. (Ex: xx/xx/xxxx)");
                DateTime userInput2 = DateTime.Parse(Console.ReadLine());

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
