using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(5);
            foreach (int i in list)
            {
                Console.WriteLine(i);
                Console.Read();
            }

        }
    }
}
