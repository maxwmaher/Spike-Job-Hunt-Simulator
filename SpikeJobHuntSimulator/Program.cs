using System;

namespace SpikeJobHuntSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your job hunt.");
            Console.Write("Please enter your name, as it appears on your resume: ");

            string name = Console.ReadLine();

            Console.WriteLine("Nice work, " + name + ", I hope you're ready to enter that a bunch of times.");

            Console.WriteLine("Okay, now what kind of experience do you have?");

            Console.WriteLine("a - I provided tech support for a mid-sized company over the last five years.");
            Console.WriteLine("b - I am a freelance writer for a magazine that has seen its circulation deprecate drastically.");
            Console.WriteLine("c - I worked for two years in the Human Resources department for the Republicrat party.");
            Console.Write("Answer: ");

            string userResponse = Console.ReadLine();

            CheckExperience(userResponse);

            static void CheckExperience(string response) {
                Experience selection = new Experience(response);
                if (selection.Selection == "a")
                {
                    Console.WriteLine("Tech support, huh?  Are you sure you're ready to hunt for development work?");
                } else if (selection.Selection == "b")
                {
                    Console.WriteLine("Lovely, and I'm sure your articles were solely responsible for keeping it alive.");
                } else if (selection.Selection == "c")
                {
                    Console.WriteLine("The Republicrats?  I would keep that information to yourself if I were you.");
                } else
                {
                    Console.WriteLine("Hey!  This game really isn't that hard.  Just enter a, b, or c, all lowercase.  Simple, right?  Let's try this again.");
                    Console.Write("Answer: ");
                    string userResponse = Console.ReadLine();
                    CheckExperience(userResponse);
                }
            }

            //if (userResponse == "a")
            //{
            //    Console.WriteLine("Tech support, huh?  Are you sure you're ready to hunt for developmemt work?");
            //}

            Console.ReadLine();
        }
    }
}
