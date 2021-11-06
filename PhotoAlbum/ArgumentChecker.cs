using System;
using System.Linq;

namespace PhotoAlbum
{
    public class ArgumentChecker
    {
        public static bool HasInvalidArgs(string[] args)
        {
            var numArgs = args.Length;
            if (numArgs == 0)
            {
                Console.WriteLine("Please provide an album id.");
                return true;
            }
            else if (numArgs > 1)
            {
                Console.WriteLine("Too many arguments provided.  Please only specify 1 album id.");
                return true;
            }
            else if (!args[0].All(char.IsDigit))
            {
                Console.WriteLine("Provide a numeric album id between 1 & 100.");
                return true;
            }
            else if (args[0].All(char.IsDigit) && int.Parse(args[0]) < 1 || int.Parse(args[0]) > 100)
            {
                Console.WriteLine("Album id provided out of range.  Please provide an album id between 1 & 100.");
                return true;
            }

            return false;
        }
    }
}
