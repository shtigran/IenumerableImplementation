using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ImplementIenumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementation of IEnumerable

            person per = new person();

            Console.WriteLine("Showing by for loop with per.data[i]");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(per.data[i]);
            }

            Console.WriteLine("\nShowing by foreach loop with per.data");
            foreach (string s in per.data)
                Console.WriteLine(s);


            Console.WriteLine("\nShowing by foreach for person class, by implementing IEnumerable interface");
            foreach (string s in per)
                Console.WriteLine(s);

            Console.ReadKey();
        }

        class person : IEnumerable
        {         
            public person()
            {              
                data[0] = "Ronald Kuman";
                data[1] = "Fran Raykard";
                data[2] = "Patrick Kluvert";
                data[3] = "Rud Gulid";
            }

            public string[] data = new string[4];

            public IEnumerator GetEnumerator()
            {
                return data.GetEnumerator();

            }
        }
    }
}