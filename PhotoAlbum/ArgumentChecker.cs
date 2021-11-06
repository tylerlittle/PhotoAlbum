using System;
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
            else if (!int.TryParse(args[0], out _))
            {
                Console.WriteLine("Provide a valid album id.");
                return true;
            }

            return false;
        }
    }
}
