using System;

namespace DemoLibrary
{
    public static class ExampleMethods
    {
        public static string LoadTextFile(string filePath)
        {
            if (filePath.Length < 10)
            {
                throw new ArgumentException("Filepath was too short", "filePath");

                // throw new FileNotFoundException();
            }

            return "The file was correctly loaded.";
        }

        public static string ReturnBleepedString(string input, string bleepedWord)
        {
            if (input.Length < 1)
            {
                throw new ArgumentException("No input given", "input");
            }

            if (bleepedWord.Length < 1)
            {
                throw new ArgumentException("No bleepable word given", "bleepedWord");
            }

            if (input.Contains(bleepedWord) == true)
            {
                return input.Replace(bleepedWord, "***");
            }
            else
            {
                return input;
            }
        }
    }
}
