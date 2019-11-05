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

            Console.WriteLine("Okay, I see you have some kind of experience.  What is it?");

            Console.WriteLine("a - I provided tech support for a mid-sized company over the last five years.");
            Console.WriteLine("b - I am a freelance writer for a magazine that has seen its circulation deprecate drastically.");
            Console.WriteLine("c - I worked for two years in the Human Resources department for the Republicrat party.");
            Console.Write("Answer: ");

            string userResponse = Console.ReadLine();

            if (userResponse == "a")
            {
                Console.WriteLine("Tech support, huh?  Are you sure you're ready to hunt for developmemt work?");
            }

            Console.ReadLine();
        }
    }
}
