using System;

namespace ExecGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 2)
            {
                Console.WriteLine("For the .exe you need at least 2 parameters in your URL");
            }
            else
            {
                Console.WriteLine("I am called from a .exe with 2 arguments : "+args[0] + " and : " + args[1]);
            }
        }
    }
}
