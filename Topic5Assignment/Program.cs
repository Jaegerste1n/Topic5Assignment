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
            int grade;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("What was your grade?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Good, you passed.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You're a failure.");
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("How old were you again?");
            int otherAge;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out otherAge);
            if (otherAge >= 16)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("The roads of this world aren't safe with You.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Good. I don't have to deal with you on the road.");
            }
            int bet;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("No No No Shut UP Gambling Time");
            Console.WriteLine("Bet Place Your Bet");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your Bet Has Been Placed: " + bet.ToString("C"));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("That Is NNOt A Valid NUMBEr");
                Console.WriteLine("Your Bet Has Been Automatically Set To $20,000");
                bet = 20000;
            }
            int otherGrade;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Stop. I forgot again, what was your grade?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out otherGrade);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (grade < 50)
            {
                Console.WriteLine("An F. You were a mistake.");
            }
            else if (grade <= 65)
            {
                Console.WriteLine("D. Pathetic.");
            }
            else if (grade <= 75)
            {
                Console.WriteLine("C? Do better.");
            }
            else if (grade <= 85)
            {
                Console.WriteLine("B. Good enough.");
            }
            else
            {
                Console.WriteLine("Wow. An A. Good job.");
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("One of these is not of the others.");
            Console.WriteLine("");
            Console.WriteLine("A) With every bite, with bone and skin");
            Console.WriteLine("B) The temple groaned, and shook again");
            Console.WriteLine("C) His dwelling place did I neglect,");
            Console.WriteLine("D) And we shall become them.");
            Console.WriteLine("");
            Console.WriteLine("Enter a letter.");
            string schizo;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            schizo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (schizo.ToLower() == "a")
            {
                Console.WriteLine("No.");
            }
            else if (schizo.ToLower() == "b")
            {
                Console.WriteLine("No, " + name);
            }
            else if (schizo.ToLower() == "c")
            {
                Console.WriteLine("No. Focus, " + name);
            }
            else if (schizo.ToLower() == "d")
            {
                Console.WriteLine("Very good. It foregoes the theme and doesn't rhyme.");
            }
            else
            {
                Console.WriteLine("...");
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The Temperature Of Water In Degrees Celsius");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int otherTemp;
            int.TryParse(Console.ReadLine(), out otherTemp);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (otherTemp <= 0)
            {
                Console.WriteLine("That's Solid I Think");
            }
            else if (otherTemp >= 1)
            {
                Console.WriteLine("That's Is Liquid I Think");
            }
            else if (otherTemp >= 100)
            {
                Console.WriteLine("That's Probably Gas");
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hold on, I forgot. How old are you again?");
            int thirdAge;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out thirdAge);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (thirdAge < 16)
            {
                Console.WriteLine("God, you're a baby.");
            }
            else if (thirdAge >= 16)
            {
                Console.WriteLine("You may be able to drive, but you cannot vote.");
            }
            else if (thirdAge >= 18)
            {
                Console.WriteLine("You can finally vote. But can't own a car.");
            }
            else if (thirdAge >= 25)
            {
                Console.WriteLine("Congrats. You're a big boy.");
            }

        }
    }
}
