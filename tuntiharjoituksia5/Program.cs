using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuntiharjoituksia5
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list for integers
            List<int> list = new List<int>();
            // boolean variable, just check for looping
            bool result;
            // ask numbers
            do
            {
                // ask number from the user (read one line)
                Console.Write("Give a number > ");
                string line = Console.ReadLine();
                // try to read number from the given line
                int number;
                result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    list.Add(number);
                }
            } while (result);
            // write some statistics
            Console.WriteLine("Average : {0}", list.Average());
            Console.WriteLine("Min : {0}", list.Min());
            Console.WriteLine("Max : {0}", list.Max());
            Console.WriteLine("Numbers count : {0}", list.Count);
            // all
            list.ForEach(item => Console.Write(item + ","));
            // sort
            list.Sort();
            // all
            Console.WriteLine();
            list.ForEach(item => Console.Write(item + ","));
            // read line to keep writelines visible
            Console.ReadLine();


        }
    }
}
