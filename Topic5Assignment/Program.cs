namespace Topic5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = 20;
            int rats = 30;
            int sludge = 15;
            Console.WriteLine("People: " + people + " Sludge: " + sludge + " Rats: " + rats);
            if (people < rats)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An abundance of rats! Far too many rats! Goodness Gracious!");
            }

            if (people > rats)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("God bless the notable lack of rats.");
            }

            if (people < sludge)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The sludge is rising.");
            }

            if (people > sludge)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O' Ground, dry be the Ground.");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What's your takeaway from this?");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
