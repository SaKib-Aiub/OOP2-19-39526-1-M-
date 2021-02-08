using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeprb
{
    class Program
    {
        static void Main(string[] args)
        {
            float phy = 88f;
            float chem = 86f;
            float bio = 78f;
            float math = 91f;
            float comp = 92f;
            float result = (phy + chem + bio + math + comp) / 5;
            Console.WriteLine("Grade " + result);
            if (result >= 90) { Console.WriteLine("Grade A+"); }
            else if (result >= 85 && result < 90) 
            { Console.WriteLine("Grade A"); }
            else if (result >= 80 && result < 85) 
            { Console.WriteLine("Grade B+"); }
            else if (result >= 75 && result < 80)
            { Console.WriteLine("Grade B"); }
            else if (result >= 50 && result < 75)
            { Console.WriteLine("Grade C+"); }
            else { Console.WriteLine("Grade F"); }
        }
    }
}