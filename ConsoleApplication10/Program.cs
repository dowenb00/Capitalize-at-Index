using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aabbccddee";
            var newstring = "";
            int count = 0;

            int[] vector = { 1, 3, 5, 7, 9, 20 };

            for (int i = 0; i < s.Length; i++)
            {
                if ( i == vector[count] - 1)
                {
                    newstring += char.ToUpper(s[i]);
                    count++;
                }
                else
                {
                    newstring += s[i];
                }    
            }

            Console.WriteLine(newstring);
        }
    }
}
