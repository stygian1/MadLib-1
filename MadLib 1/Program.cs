using System;

namespace Game
{
    static class Madlib
    {
        //declare variables
        static String Creature;
        static String Luminous;
        static String Ghastly;
        static String Spectral;
        static String Countryman;
        static String Farrier;
        static String Farmer;
        static String Dreadful;
        static String Apparition;
        static String Hound;
        static String Story;
        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            //write out a header

            Console.WriteLine("--------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("--------");

        }

        static void GetWords()
        {
            //ask player to enter words

            Console.WriteLine("Please enter a noun: ");
            Creature = Console.ReadLine();
            Console.WriteLine("Please enter an adjective: ");
            Luminous = Console.ReadLine();
            Console.WriteLine("Please enter an adjective: ");
            Ghastly = Console.ReadLine();
            Console.WriteLine("Please enter an adjective: ");
            Spectral = Console.ReadLine();
            Console.WriteLine("Please enter a vocation: ");
            Countryman = Console.ReadLine();
            Console.WriteLine("Please enter a vocation: ");
            Farrier = Console.ReadLine();
            Console.WriteLine("Please enter a vocation: ");
            Farmer = Console.ReadLine();
            Console.WriteLine("Please enter an adjective: ");
            Dreadful = Console.ReadLine();
            Console.WriteLine("Please enter a noun: ");
            Apparition = Console.ReadLine();
            Console.WriteLine("Please enter a noun: ");
            Hound = Console.ReadLine();
        }

        static void WriteStory()
        {
            //write out finished story

            Story = "They all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them a hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.";
            Console.WriteLine(Story);
        }

        static void End()
        {
            //keep window open and prompt for exit

            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
        class Program
        {
            static void Main()
            {
                //original statements were here
                Madlib.Run();
            }
        }
    }
