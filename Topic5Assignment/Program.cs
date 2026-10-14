using System.Numerics;

namespace Topic5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chosenMethod;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Select a method to run.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("tutorial");
            Console.WriteLine("spaceboxing");
            Console.WriteLine("calculator");
            Console.WriteLine("quiz");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            chosenMethod = Console.ReadLine();
            if (chosenMethod.ToLower() == "tutorial")
            {
                Console.Clear();
                Tutorial();
            }
            else if (chosenMethod.ToLower() == "spaceboxing")
            {
                Console.Clear();
                SpaceBoxing();
            }
            else if (chosenMethod.ToLower() == "calculator")
            {
                Console.Clear();
                Calculator();
            }
            else if (chosenMethod.ToLower() == "quiz")
            {
                Console.Clear();
                Quiz();
            }


        }
        public static void Tutorial()
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
            Console.WriteLine("Hold on, I forgot. How old are you again?");
            int fourthAge;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out fourthAge);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (fourthAge >= 13 && fourthAge <= 19)
            {
                Console.WriteLine("You're a wee baby.");
            }
            else
            {
                Console.WriteLine("Okay.");
            }
            Console.WriteLine("How much money do you have?");
            int money;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out money);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Are you working tonight? Yes or no");
            string work;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            work = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (money >= 20 && work.ToLower() == "no")
            {
                Console.WriteLine("You could go see a movie. Good for you.");
            }
            else
            {
                Console.WriteLine("Shame");
            }
            string password;


            Console.WriteLine("What's the magic word again?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (password == "fireball")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Look At What You've Done, You've Reduced Her To Ash!");
            }
            else
            {
                Console.WriteLine("No. Try again.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                password = Console.ReadLine();
                if (password == "fireball")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Look At What You've Done, You've Reduced Her To Ash!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("No. Try again.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    password = Console.ReadLine();
                    if (password == "fireball")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Look At What You've Done, You've Reduced Her To Ash!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("No. Try again.");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        password = Console.ReadLine();
                        if (password == "fireball")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Look At What You've Done, You've Reduced Her To Ash!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("No. Try again.");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            password = Console.ReadLine();
                            if (password == "fireball")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Look At What You've Done, You've Reduced Her To Ash!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("You're a failure.");
                            }
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Nevertheless Regardless Moving On Doesn't Matter");
            Console.WriteLine("Enter The Topping Pepperoni or Rats");
            string topping;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            topping = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (topping.ToLower() == "pepperoni" || topping.ToLower() == "rats")
            {
                Console.WriteLine("Okay");
            }
            else
            {
                Console.WriteLine("NO NO NO NO NO NO NO NO NO");
            }
            Console.WriteLine("The Buss Pass Is $3.50");
            Console.WriteLine("How Old Are You Again? Scratch That You're " + fourthAge + " We Know This Already");
            if (fourthAge >= 60 || fourthAge <= 12)
            {
                Console.WriteLine("Dumb Babies And Stinky Old Men Are Instead Charged $20,000");
            }
            Console.WriteLine("Hey Hey What's      Your Favorite Animal");
            string animal;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            animal = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (animal.ToLower() == "rat" || animal.ToLower() == "shoggoth")
            {
                Console.WriteLine("What");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("What Is, The Temperature Outside");
            int outTemp;
            string weather;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out outTemp);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("What Is The, Weather Outside");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            weather = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (weather == "sunny" || outTemp >= 25)
            {
                Console.WriteLine("Go In Water");
            }
            else
            {
                Console.WriteLine("Go To Sleep");
            }
            int personOne, personTwo, personThree;
            Console.WriteLine("Enter An Age");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out personOne);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter An Age");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out personTwo);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter An Age");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out personThree);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (personTwo == personOne && personTwo != personThree)
            {
                Console.WriteLine("Guy 2 Is The Same Age As Someone But Not Both");
            }
            else if (personTwo == personThree && personTwo != personOne)
            {
                Console.WriteLine("Guy 2 Is The Same Age As Someone But Not Both");
            }
            if (personOne != personTwo && personOne != personThree)
            {
                Console.WriteLine("Guy 1 Does Not Share An Age With Anyone");
            }
            if (personOne == personTwo && personOne == personThree && personTwo == personThree)
            {
                Console.WriteLine("They Are All The Same Age");
            }
            if (personOne != personTwo && personOne != personThree && personTwo != personThree)
            {
                Console.WriteLine("They Are All Different Ages");
            }

        }

        public static void SpaceBoxing()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What is your current Earth weight?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int weight;
            int.TryParse(Console.ReadLine(), out weight);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (weight >= 175)
            {
                Console.WriteLine("Fatty.");
            }
            Console.WriteLine("I have information for the following planets:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1: Venus        2: Mars        3: Evil Jupiter");
            Console.WriteLine("");
            Console.WriteLine("4: Petrichor V  5: Uranus      6: Hoxxess V");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Where are you headed?");
            int planet;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out planet);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (planet == 1)
            {
                Console.WriteLine("Your weight would be " + weight * 0.78 + " on that planet.");
            }
            else if (planet == 2)
            {
                Console.WriteLine("Your weight would be " + weight * 0.39 + " on that planet.");
            }
            else if (planet == 3)
            {
                Console.WriteLine("Your weight would be " + weight * 2.65 + " on that planet.");
            }
            else if (planet == 4)
            {
                Console.WriteLine("Your weight would be " + weight * 1.17 + " on that planet.");
            }
            else if (planet == 5)
            {
                Console.WriteLine("Your weight would be " + weight * 1.05 + " on that planet.");
            }
            else if (planet == 6)
            {
                Console.WriteLine("Your weight would be " + weight * 1.23 + " on that planet.");
            }
            else
            {
                Console.WriteLine("Oh, you're funny.");
            }

        }
        public static void Calculator()
        {
            double numberOne, numberTwo;
            string calcOperator;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter A Number");
            Console.ForegroundColor = ConsoleColor.DarkGray;
       
            double.TryParse(Console.ReadLine(), out numberOne);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter An Operator (+, -, /, *)");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            calcOperator = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter A Number");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out numberTwo);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (calcOperator == "+")
            {
                Console.WriteLine(+ numberOne + " " + calcOperator + " " + numberTwo + " = " + (numberOne + numberTwo));
            }
            else if (calcOperator == "-")
            {
                Console.WriteLine(+ numberOne + " " + calcOperator + " " + numberTwo + " = " + (numberOne - numberTwo));
            }
            else if (calcOperator == "/")
            {
                Console.WriteLine(+ numberOne + " " + calcOperator + " " + numberTwo + " = " + (numberOne / numberTwo));
            }
            else if (calcOperator == "*")
            {
                Console.WriteLine(+ numberOne + " " + calcOperator + " " + numberTwo + " = " + (numberOne * numberTwo));
            }
            else
            {
                Console.WriteLine("Syntax Error");
            }

        }
        public static void Quiz()
        {
            int score;
            string answer;
            score = 0;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Which of these doesn't belong?");
            Console.WriteLine("A) Dark worms scream inside my brain");
            Console.WriteLine("B) Begging me to eat again");
            Console.WriteLine("C) Hearts and blood and bile and soil");
            Console.WriteLine("D) To the end with bad effect");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("No. Don't be palsy now.");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("Incorrect.");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("Squeemish? No.");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("Good. You have pattern recognition.");
                score = score + 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else
            {
                Console.WriteLine("...");
                score = score - 3;
                Console.WriteLine("Current score: " + score + "");
            }

            Console.WriteLine("Who here hates Scotland the most?");
            Console.WriteLine("A) Bulldog Browns");
            Console.WriteLine("B) Simon Hayes");
            Console.WriteLine("C) Chaos Lord Zargothrax");
            Console.WriteLine("D) Sgt. Doe");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("No. What?");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("And why's that?");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("Nobody else is going to tear open space to blow up Auchtertool specifically.");
                score = score + 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("He's got a buddy there.");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else
            {
                Console.WriteLine("...");
                score = score - 3;
                Console.WriteLine("Current score: " + score + "");
            }

            Console.WriteLine("''My children drowned, so I took theirs for mine.''");
            Console.WriteLine("''And replaced their skeleton, with long; silver twine.''");
            Console.WriteLine("A) Taker");
            Console.WriteLine("B) Deer Lord");
            Console.WriteLine("C) Merchant");
            Console.WriteLine("D) Parasite");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("Like a carrot on the end of a stick.");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("Why would it do that?");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("Who happened to sell puppets. (past tense)");
                score = score + 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("What would that have to do with anything?");
                score = score - 1;
                Console.WriteLine("Current score: " + score + "");
            }
            else
            {
                Console.WriteLine("...");
                score = score - 3;
                Console.WriteLine("Current score: " + score + "");
            }

            Console.WriteLine("placeholder");
            Console.WriteLine("A) placeholder");
            Console.WriteLine("B) placeholder");
            Console.WriteLine("C) placeholder");
            Console.WriteLine("D) placeholder");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (answer.ToUpper() == "A")
            {
                Console.WriteLine("placeholder");
                score = score + 1;
                Console.WriteLine("Final score: " + score + "");
            }
            else if (answer.ToUpper() == "B")
            {
                Console.WriteLine("placeholder");
                score = score - 1;
                Console.WriteLine("Final score: " + score + "");
            }
            else if (answer.ToUpper() == "C")
            {
                Console.WriteLine("placeholder");
                score = score - 1;
                Console.WriteLine("Final score: " + score + "");
            }
            else if (answer.ToUpper() == "D")
            {
                Console.WriteLine("placeholder");
                score = score - 1;
                Console.WriteLine("Final score: " + score + "");
            }
            else
            {
                Console.WriteLine("...");
                score = score - 990;
                Console.WriteLine("Final score: " + score + "");
            }
            Console.WriteLine("That's that, then.");
            if (score <= -5)
            {
                Console.WriteLine("You are, dare I say, pathetic.");
            }
            else if (score < 0)
            {
                Console.WriteLine("Couldn't crawl yourself out. Unfortunate.");
            }
            else if (score == 0)
            {
                Console.WriteLine("Zero. Really?");
            }
            else if (score == 1)
            {
                Console.WriteLine("Well, you got one.");
            }
            else if (score == 2)
            {
                Console.WriteLine("Pity pass.");
            }
            else if (score == 3)
            {
                Console.WriteLine("Really couldn't push through to 4?");
            }
            else if (score == 4)
            {
                Console.WriteLine("Good job.");
            }
        }
    }
}
