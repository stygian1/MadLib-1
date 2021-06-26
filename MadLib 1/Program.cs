using System;
using System.Globalization;

namespace Game
{
    static class Madlib
    {
        //declare variables
        static string[] Words = new string[] { "creature", "luminous", "ghastly", "spectral", "countryman", "farrier", "farmer", "dreaful", "apparition", "hound" };
        static string[] Prompts = new string[] { "noun", "adjective", "adjective", "adjective", "occupation", "occupation", "occupation", "adjective", "noun", "noun" };
        static string Story;
        static string GameTitle;
public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            //Set window bar title
            Console.Title = "Make a Madlib";
            //write out a header

            Console.WriteLine("--------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("--------");

        }

        static void GetWords()
        {
            //ask player to enter words

            for (int i = 0; i < Words.Length; i++)
            {
                Console.Write("Please enter a/an " + Prompts[i] + ": ");
                Words[i] = Console.ReadLine();
            }
        }

        static void WriteStory()
        {
            //Concatenate strings to make a title
            GameTitle = "The " + Words[1] + " " + Words[2] + " " + Words[0];

            //So we can capitalize the words in our title
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);

            //Write the title to the console window
            Console.WriteLine(GameTitle);

            //Write out story
            Story = "They all agreed that it was a huge {0}, {1}, {2} and {3}. \nI have cross-examined these men, one of them a hard-headed {4}, one a {5}, and one a moorland {6}, who all tell the same story\nof this {7} {8}, exactly corresponding to the {9} of the legend.";
            Console.WriteLine(Story, Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6], Words[7], Words[8], Words[9]);
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
                Madlib.Run();
            }
        }
    }
