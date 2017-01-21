# Ienumerable Implementation for User Class
# C#6.0  .NET FRAMEWORK 4.6
----
This project show how You can implement Ienumerable interface for Your own classes.
----
### Purpose
The goal of this project show how You can obtain foreach loop for Your class object.
----
### ImplementIenumerable implementation
```c#

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
```

### Result
```
Showing by for loop with per.data[i]
Ronald Kuman
Fran Raykard
Patrick Kluvert
Rud Gulid

Showing by foreach loop with per.data
Ronald Kuman
Fran Raykard
Patrick Kluvert
Rud Gulid

Showing by foreach for person class, by implementing IEnumerable interface
Ronald Kuman
Fran Raykard
Patrick Kluvert
Rud Gulid
```
