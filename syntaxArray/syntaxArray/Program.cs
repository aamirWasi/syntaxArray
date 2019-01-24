using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //one dimensional array
            int[] favNums = new int[3];
            favNums[0] = 2;
            favNums[1] = 62;
            favNums[2] = 22;
            string[] custNames = { "Rick", "Bob", "Shu", "Shally" };
            var employees = new[] { "shrist", "fhana", "She" };
            object[] randomArray = { "Bulk", 2, 5.46, "Paul" };
            foreach(string k in custNames)
            {
                Console.WriteLine("{0}",k);
            }
        }
    }
}
