using System;

namespace homework_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "C", "a", "v", "i", "d", "a", "n" };
            Word(name);

        }

        static void Word(string[] name)
        {
            int count = 0;

            for (int i = 6; i < name.Length; i--)
            {
                count++;
                Console.WriteLine(name[i]);
            }

        }




    }
}
