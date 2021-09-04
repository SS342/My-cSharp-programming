using System;

namespace A
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pa-Ra-Pa-Pa");

            string sentense = "";

            for (; ; )
            {
                Console.WriteLine("Input");
                string line = Console.ReadLine();

                string[] terms = { "EXIT", "QUIT", "exit", "quit" };

                bool quitting = false;

                foreach (string term in terms)
                {
                    if (String.Compare(line, term) == 0)
                    {
                        quitting = true;
                    }
                }
                if (quitting == true)
                {
                    break;
                }
                sentense = String.Concat(sentense, line);
                Console.WriteLine("\n You Input:\n" + sentense);
            }
        }
    }
}