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

            Console.WriteLine($"Today's date is {currentDate.ToString("MM/dd/yyyy")}");

            DateTime christmasDate = new DateTime(currentDate.Year, 12, 25);
            TimeSpan daysUntilChristmas = christmasDate - currentDate;
            int days = (int)daysUntilChristmas.TotalDays;

            Console.WriteLine($"Days left until Christmas this year: {days} days");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Width Input: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Height Input: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.ReadKey();
        }
    }
}