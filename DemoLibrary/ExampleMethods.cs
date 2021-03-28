using System.IO;

namespace DemoLibrary
{
    public static class ExampleMethods
    {
        public static string LoadTextFile(string filePath)
        {
            if (filePath.Length < 10)
            {
                throw new FileNotFoundException();
            }

            return "The file was correctly loaded.";
        }
    }
}
