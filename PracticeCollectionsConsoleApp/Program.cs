using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PracticeCollectionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string>();
            options.Add("Arrays");
            options.Add("List");
            options.Add("Dictionary");
            bool validOption = false;
            while (validOption == false)
            {
                int k = 1;
                Console.WriteLine("Which would you like to see me practice?");
                foreach (string item in options)
                {
                    Console.WriteLine($"{k}) {item}");
                    k++;
                }
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == options[0].ToLower() || answer == "1")
                {
                    Arrays();
                    validOption = true;
                }
                else if (answer == options[1].ToLower() || answer == "2")
                {
                    Lists();
                    validOption = true;
                }
                else if (answer == options[2].ToLower()|| answer=="3")
                {
                    Dictionaries();
                    validOption = true;
                }
                else
                {
                    Console.WriteLine("I don't get it");
                    continue;
                }

            }
     
           
            
        }
        public static void Arrays()
        {
            //arrays
            //            • Create a string array that will store the names of three people.
            string[] bestFriends = new string[3];
            //• Populate that array with the names of your three best friends.
            bestFriends[1] = "Alyson";
            bestFriends[0] = "Kelsie";
            bestFriends[2] = "Marc";

            //o If you don’t have three friends, make some up.
            //• Loop through the array and display a greeting to each of your friends.
            foreach (string friend in bestFriends)
            {
                Console.WriteLine($"Hello {friend}!");
            }
            //You want to make sure that you don’t have lunch with any want you don’t like, so you create a “lunch buddy” list.The table seats eight people, and you want every seat taken.
            //• Create another string array to store the names of 8 people
            string[] lunchBuddies = new string[8];

            //• This array will hold the names of 8 people you would like to have lunch with
            //• Add your best friends to this new array and populate the remaining elements with five other names.
            bestFriends.CopyTo(lunchBuddies, 0);
            lunchBuddies[3] = "Chris";

            lunchBuddies[4] = "Becky";
            lunchBuddies[5] = "Amy";
            lunchBuddies[6] = "Peter";
            lunchBuddies[7] = "Greg";
            //• Display a lunch invitation to each person informing them how many people are on the list
            foreach (string buddy in lunchBuddies)
            {
                Console.WriteLine($"Hi {buddy}- \nWould you like to have lunch with me?\n I am inviting {lunchBuddies.Length} people!");
                Thread.Sleep(1000);
                Console.Clear();

            }
            //            You need to make sure you maintain an average test score of 80.Otherwise, you’ll be grounded.
            //• Create an empty array that will store ten test scores
            double[] testScores = new double[10];
            Console.WriteLine("We're going track the grades on your 10 tests");
            //• Use the Console window to populate the test scores

            int i = 0;
            Console.WriteLine();
            foreach (double item in testScores)
            {
                bool validScore = false;
                Console.WriteLine($"Please enter the score for test {i + 1}:");
                while (validScore == false)
                {
                    validScore = double.TryParse(Console.ReadLine(), out double result);
                    if (validScore == false)
                    {
                        Console.WriteLine("I'm sorry, that wasn't a valid test score. Please enter your next test score.");
                    }
                    else
                    {
                        testScores[i] = result;
                        i++;
                    }
                }
            }
            //• Display the average grade in the Console window
            Console.Clear();
            Console.WriteLine($"Your average test score is {testScores.Average()}");
            Thread.Sleep(1000);
        }
        public static void Lists()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
            Console.WriteLine("Lists!");
            //            You have graduated from school and gotten a job as a Software Developer. You are going to celebrate by having a party.
            //• Create a list to store your guest list
            List<string> guestList = new List<string>() { "Abbey", "Michele", "GG", "Allison", "Amy", "Debbie" };
            //• Populate your list with some guests
            //• Loop through your list to display an invitation message
            foreach (string guest in guestList)
            {
                Console.WriteLine($"Hi {guest}!\nYou're invited to my party!");
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;


            //            You’ve decided to rent a hall and have a bigger party, but you can’t think of anyone else to invite.
            //• Write the code that will let the user invite five more people to your party.
            Console.WriteLine("I think we can invite 5 more people!\nWho should we invite?");

            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine($"Extra Guest #{j} should be:");
                guestList.Add(Console.ReadLine());
            }

            //• Display the new guest list
            Console.WriteLine("Our updated guest list is:");
            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
            //• Five additional guests were too many, and you have exceeded the room limit. Allow the user to uninvite any two guests by name.
            Console.WriteLine("Yikes! I was wrong...That's too many. We need to remove 2 people from the guest list!");
            for (int k = 1; k <= 2; k++)
            {
                Console.WriteLine("Who should we remove?");
                bool validPerson = false;
                while (validPerson == false)
                {
                    string answer = Console.ReadLine().Trim();
                    if (guestList.IndexOf(answer) != -1)
                    {
                        guestList.Remove(answer);
                        validPerson = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I can't find that person..Who do you want to remove from the guest list?");

                    }
                }
            }
            //o If the same name shows up twice on the list, remove the one that was entered last.
            guestList = guestList.Distinct().ToList();
            //            The hall caught on fire two weeks before your event. Now you have to cut your guest list in half.
            //• Write the code that will reduce your list in half by uninviting people the people that were invited last.
            Console.Clear();
            int halfGuests = guestList.Count() / 2;

            Console.WriteLine($"The hall caught fire..\nThey're fixing it up...\nbut they'll only be able to accomodate {guestList.Count() / 2} people. We'll have to uninvite the second half of the list");
            //• Create a “waiting list” and put the people you are removing onto the waiting list
            List<string> waitingList = new List<string>();
            for (int p = halfGuests - 1; p < guestList.Count() - 1; p++)
            {
                waitingList.Add(guestList[p]);
            }
            guestList.RemoveRange(guestList.Count() / 2 - 1, guestList.Count() / 2);
            //• Display a message to those guests, explaining what happened. Tell them what number they are on the waiting list and the total number of people on the list.
            string message = "Hello";
            foreach (string name in waitingList)
            {
                message += name + ", ";
            }
            message += "I am so sorry. There was a fire and we need to cut the guest list" +
                $"We have added you to a waitlist for the party. There are {waitingList.Count()} people on the waiting list";
            Console.WriteLine(message);
            //Now that you have your guest list, you want to know how much money they are going to gift you.
            List<double> moneyList = new List<double>();
            //• Display a message asking each guest how much they are going to give.
            foreach (string name in guestList)
            {
                Console.WriteLine($"Hello {name}, How much money are you going to give me?");
                bool validAnswer = false;
                while (validAnswer == false)
                {
                    validAnswer = double.TryParse(Console.ReadLine(), out double result);
                    if (validAnswer == false)
                    {
                        Console.WriteLine("That doesn't sound right, try again. (don't enter a the dollar sign)");

                    }
                    else
                    {
                        moneyList.Add(result);

                    }
                }
            }
            //• Store those amounts in another list.
            //• Display a message with the total amount you are expecting to receive.
            Console.WriteLine($"You can expect {moneyList.Sum():c} from your party");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public static void Dictionaries()
        {
            Console.WriteLine("Dictionaries");
            Dictionary<string, int> venue = new Dictionary<string, int>() { { "DisneyLand", 90 }, { "Church", 60 }, { "Chuck-E-Cheeze", 100 } };

            foreach (KeyValuePair<string, int> item in venue)
            {
                Console.WriteLine($"{item.Key} has a capacity of {item.Value} people");
            }

        }

    }

}
