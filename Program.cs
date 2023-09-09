namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "James";
            string location = "NY";

            Console.WriteLine($"My name is {name}, and I'm from {location}");

            DateTime currentDate = DateTime.Now;

            Console.WriteLine($"Today's date is {currentDate.ToString("M / d / yyyy")}");

            DateTime christmasDate = new DateTime(currentDate.Year, 12, 25);
            TimeSpan daysUntilChristmas = christmasDate - currentDate;
            int days = (int)daysUntilChristmas.TotalDays;

            Console.WriteLine($"Days left until Christmas this year: {days} days");

            Console.ReadKey();
        }
    }
}