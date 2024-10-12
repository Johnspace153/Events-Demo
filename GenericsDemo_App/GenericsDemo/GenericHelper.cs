using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class GenericHelper<T>
    {
        public List<T> Items { get; set; } = new List<T>();


        public void PrintToConsole(T item)
        {
            Items.Add(item);

            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public string FizzBuzz(T item)
        {
            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }
            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }
            return output;

        }
    }
}
    
