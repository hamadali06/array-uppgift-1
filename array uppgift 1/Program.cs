using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = { "Första meningen.", "Andra meningen.", "Tredje meningen." };
            foreach (string mening in meningar)
            {
                Console.WriteLine(mening + "\n");
            }
        }
    }
}
