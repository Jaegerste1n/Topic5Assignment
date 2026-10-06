namespace Topic5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people;
            int rats;
            int sludge;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The population?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out people);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The rat population?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out rats);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The sludge levels?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out sludge);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();
           
            sludge += 5;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("People: " + people + " Sludge: " + sludge + " Rats: " + rats);
            if (people >= sludge)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The people have risen above the sludge. Or are equal to it.");
            }
            if (people <= sludge)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The people have sunk far below the sludge. Or are equal to it.");
            }
            if (people == sludge) //if fires the code in braces below it if certain conditions are true.
            { //the open brace is the start of the conditional code
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Humanity has been reduced to The Sludge.");
            } //the closed brace is the end of it
            Console.WriteLine("");

            string rat;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The giant rat, who _____ ___ ___ _____");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            rat = Console.ReadLine();
            if (rat.ToLower() == "makes all the rules")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Yeah");
            }
            Console.WriteLine("");
            string magicWord;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What's the magic word?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            magicWord = Console.ReadLine();
            if (magicWord.ToLower() == "fireball")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Now look at what you've done, you've reduced him to ash!");
                Console.WriteLine("Must I do everything around here?");
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Who are you anyway?");
            string name;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Right. " + name + ". How old are you?");
            int age;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out age);
            if (age >= 25)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You could've done anything legal, " + name + ".");
            }
            if (age < 25)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You can't drink, " + name + ".");
            }
            if (age < 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You can't vote, " + name + ".");
            }
            if (age < 16)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You can't even drive, " + name + ".");
            }
            Console.WriteLine("");
            Console.WriteLine("Right, give me a number that can freeze water.");
            int temp;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out temp);
            if (temp == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("In celsius, yes.");
            }
            if (temp == 32)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("In fahrenheit, yes.");
            }
            if (temp == 273)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Get a load of this guy, thinks knowing kelvin makes him smart.");
            }
            

        }
    }
}
