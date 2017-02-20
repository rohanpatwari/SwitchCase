using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 5, 6 }; 
            switch (array[0])
            {
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                    switch (array[1])
                    {
                        case 5:
                            Console.WriteLine(5);
                            break;
                    }
                    break;       
            }
            Console.ReadLine();
        }
    }
}
