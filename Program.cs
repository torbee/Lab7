using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class.");
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Which student would you like to learn more about? (Enter a number between 1 and 13");
                int input = int.Parse(Console.ReadLine());
                List<string> firstname = new List<string>();
                firstname.Add("");
                firstname.Add("Ariana");
                firstname.Add("Christopher");
                firstname.Add("Diane");
                firstname.Add("Jillane");
                firstname.Add("JJ");
                firstname.Add("Kelsey");
                firstname.Add("Megan");
                firstname.Add("Ryan");
                firstname.Add("Sabrina");
                firstname.Add("Stephanie");
                firstname.Add("Tommy");
                firstname.Add("Josh");
                firstname.Add("Tori");

                List<string> lastname = new List<string>();
                lastname.Add("");
                lastname.Add("Waller");
                lastname.Add("Helgeson");
                lastname.Add("Watts");
                lastname.Add("Cook");
                lastname.Add("Ryan");
                lastname.Add("Perdue");
                lastname.Add("Norton");
                lastname.Add("Slager");
                lastname.Add("Mason");
                lastname.Add("Banks");
                lastname.Add("Waalkes");
                lastname.Add("Winchester");
                lastname.Add("Boone");

                List<string> hometowns = new List<string>();
                hometowns.Add("");
                hometowns.Add("Atlanta, GA");
                hometowns.Add("Somewhere in Ohio");
                hometowns.Add("");
                hometowns.Add("Rockford, MI");
                hometowns.Add("Lake Orion, MI");
                hometowns.Add("");
                hometowns.Add("Lansing, MI");
                hometowns.Add("");
                hometowns.Add("");
                hometowns.Add("Highland, MI");
                hometowns.Add("Raleigh, NC");
                hometowns.Add("");
                hometowns.Add("Marne, MI");

                List<string> favfoods = new List<string>();
                favfoods.Add("");
                favfoods.Add("");
                favfoods.Add("");
                favfoods.Add("");
                favfoods.Add("sushi");
                favfoods.Add("strawberries");
                favfoods.Add("");
                favfoods.Add("salads");
                favfoods.Add("");
                favfoods.Add("");
                favfoods.Add("seafood");
                favfoods.Add("chicken curry");
                favfoods.Add("");
                favfoods.Add("chocolate");

                if (input >= 1 && input <= 13)
                {
                    Console.WriteLine($"Student {input} is {firstname[input]} {lastname[input]}.");
                }
                else
                {
                    Console.WriteLine("Student does not exist. Please enter a number between 1 and 13.");
                }

                Console.WriteLine($"What would you like to learn about {firstname[input]}? (enter 'hometown' or 'favorite food'): ");
                string moreinfo = Console.ReadLine();
                moreinfo = moreinfo.ToLower();

                if (moreinfo == "hometown")
                {
                    while (hometowns[input] != "")
                    {
                        Console.WriteLine($"{firstname[input]} is from {hometowns[input]}.");
                        break;
                    }
                    while (hometowns[input] == "")
                    {
                        Console.WriteLine($"{firstname[input]} has not provided this information.");
                        break;
                    }
                }
                else if (moreinfo == "favorite food")
                {
                    while (favfoods[input] != "")
                    {
                        Console.WriteLine($"{firstname[input]}'s favorite food is {favfoods[input]}.");
                        break;
                    }
                    while (favfoods[input] == "")
                    {
                        Console.WriteLine($"{firstname[input]} has not provided this information");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again.");
                }
                //Console.WriteLine($"Would you like to learn more information about {firstname[input]}?");
                //string moreInfoAgain = Console.ReadLine();
                //wanted to throw in another loop or method but then it wouldn't pull from the lists
                run = Continue();
            }
        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Would you like to look up a new student? (y/n):");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                run = true;
            }
            else if (answer == "n" || answer == "N")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Input not valid. Please try again.");
                run = Continue();
            }
            return run;
        }
    }
}
