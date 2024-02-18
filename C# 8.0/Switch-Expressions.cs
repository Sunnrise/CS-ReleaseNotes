using System;

class Program
{
    static void Main(string[] args)
    {
        #region General way

        string message= "";
        switch (DateTime.Now.DayOfWeek)     
        {
            case DayOfWeek.Sunday:
                message="Today is Sunday";
                break;
            case DayOfWeek.Monday:
                message = "Today is Monday";
                break;
            case DayOfWeek.Tuesday:
                message = "Today is Tuesday";
                break;
            case DayOfWeek.Wednesday:
                message = "Today is Wednesday";
                break;
            case DayOfWeek.Thursday:
                message = "Today is Thursday";
                break;
            case DayOfWeek.Friday:
                message = "Today is Friday";
                break;
            case DayOfWeek.Saturday:
                message = "Today is Saturday";
                break;
            default:
                break;
            
        }
        Console.WriteLine(message);
        #endregion

        #region Switch Expression

        string message = DateTime.Now.DayOfWeek switch
        {
            DayOfWeek.Sunday => "Today is Sunday",
            DayOfWeek.Monday => "Today is Monday",
            DayOfWeek.Tuesday => "Today is Tuesday",
            DayOfWeek.Wednesday => "Today is Wednesday",
            DayOfWeek.Thursday => "Today is Thursday",
            DayOfWeek.Friday => "Today is Friday",
            DayOfWeek.Saturday => "Today is Saturday"
            
        };
        Console.WriteLine(message);




        #endregion
//The main difference between Switch Case and Switch Expression is Code Clarity.
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
