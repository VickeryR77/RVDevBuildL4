using System;
using System.Runtime.CompilerServices;

namespace StudentArray
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            What will the application do?
            ● Provide information about students in a class.
            ● Prompt the user to ask about a particular student.
            ● Give proper responses according to user-submitted information.
            ● Ask if user would like to learn about another student.

            Build Specifications/Grading Points:
            • Create 3 arrays and fill them with student information—one with name, one with favorite food, one with previous title (2 points total)
            • Ask the user which student they want to know about and take input (1 point)
            • Convert the input to an integer (1 point)
            • Make sure the input is within range for your arrays (1 point)
            • Prompt for corrected input if it’s not an integer or out of range (1 point)
            • Ask the user whether they want favorite candy or previous title and take input (1 point)
            • Prompt again if they entered a category that doesn’t exist (1 point)
            • Display the relevant information (1 point)
            • As if the user would like to learn about another student, take input, and loop back if they do (1 point)

            */
            Build();
        }


        public static void Build()
        {
            string[] name = { "", "Alfred", "Bert", "Chris", "Dean", "Earl", "Fergus", "Greg", "Howard", "Ignis", "Justin", "Keran", "Luke", "Mark", "Nate", "Orion", "Pete" };
            string[] title = { "", "1st Grade", "1st Grade", "2nd Grade", "2nd Grade", "3rd Grade", "3rd Grade", "4th Grade", "4th Grade", "5th Grade", "5th Grade", "6th Grade", "6th Grade", "7th Grade", "7th Grade", "8th Grade", "8th Grade" };
            string[] candy = { "", "Twix", "Skittles", "Milkduds", "Pie", "Rock Candy", "Lemonheads", "Starburst", "Almond Joy", "Whatchamacallit", "Baby Ruth", "Big League Chew", "Ice Cream", "Chocolate", "Chocolate Truffles", "Tofifee", "Toblorone" };


            bool running = true;
            while (running) //Program Loop
            {
                Console.Clear();
                bool intro = true;
                while (intro) //Loop for Class / Student ask
                {
                    Console.WriteLine("Are you looking to get information on the class or a student? (Class / Student)");
                    string introAnswer = Console.ReadLine();
                    string lowerIntroAnswer = introAnswer.ToLower();
                    if (lowerIntroAnswer == "class")
                    {
                        ShowClass(); //Method that prints the array through a for loop.
                        Console.WriteLine("");
                        continue; //Reruns the current loop.
                    }
                    else if (lowerIntroAnswer == "student")
                    {
                        break; //Breaks the current loop.
                    }
                    else
                    {
                        continue;
                    }
                }

                GetValidIndex(out int index); //Makes sure our number is an integer and in the appropriate range.

                bool runningTwo = true;
                while (runningTwo) //Additional information choice for candy or previous title.
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to know this student's title or candy preference? (Title / Candy)");
                    string answer = Console.ReadLine();
                    string lowerAnswer = answer.ToLower();

                    if (lowerAnswer == "title")
                    {
                        Console.WriteLine($"Great! You've selected: ");
                        Console.WriteLine("");
                        Console.WriteLine($"Student   Name: {name[index]}");
                        Console.WriteLine($"Previous Title: {title[index]}");
                        break;
                    }
                    else if (lowerAnswer == "candy")
                    {
                        Console.WriteLine($"Great! You've selected: ");
                        Console.WriteLine("");
                        Console.WriteLine($"Student   Name: {name[index]}");
                        Console.WriteLine($"Favorite Candy: {candy[index]}");
                        break;
                    }

                    else
                    {
                        continue;
                    }
                }

                bool runningThree = true;
                while (runningThree) //Remaining information choice.
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would you like more information on that student? (Y/N)");
                    string moreInfo = Console.ReadLine();
                    string lowerMoreInfo = moreInfo.ToLower();

                    if (lowerMoreInfo == "y")
                    {
                        Console.Clear();
                        Console.WriteLine($"Great! You've selected: ");
                        Console.WriteLine("");
                        Console.WriteLine($"Student   Name: {name[index]}");
                        Console.WriteLine($"Favorite Candy: {candy[index]}");
                        Console.WriteLine($"Previous Title: {title[index]}");
                        break;

                    }
                    else if (lowerMoreInfo == "n")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                GetRunAgain(out running); //Restart from the top?

            }
        }

        public static void GetValidIndex(out int index)
        {
            Console.WriteLine("Which student are you looking to get more info on? (1-16)");
            bool isValid = int.TryParse(Console.ReadLine(), out index);
            while (!isValid || index <= 0 || index > 16)
            {
                Console.WriteLine("Sorry, no student IDs match that number. Please select from 1 to 16");
                isValid = int.TryParse(Console.ReadLine(), out index);
            }
        }

        public static void GetRunAgain(out bool goTime)
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to check information regarding the class again? (Y/N)");
            string answer = Console.ReadLine();
            string lowerAnswer = answer.ToLower();

            if (lowerAnswer == "y")
            {
                goTime = true;
            }
            else if (lowerAnswer == "n")
            {
                goTime = false;
            }
            else
            {
                GetRunAgain(out goTime);
            }
        }

        public static void ShowClass()
        {


            string[] name = { "", "Alfred Abaddon", "Bert Baal", "Chris Caim", "Dean Winchester", "Earl Eligos", "Fergus MacLeod", "Greg Gremory", "Howard Halphas", "Ignis Ifrit", "Justin Jinn", "Keran Krampus", "Luke Legion", "Mark Malphas", "Nate Naberius", "Orion Orobas", "Pete Pazuzu" };

            Console.WriteLine("");
            for (int i = 1; i < name.Length; i++)
            {
                Console.WriteLine($"{name[i]}");
            }
            Console.WriteLine("");
        }
    }
}
