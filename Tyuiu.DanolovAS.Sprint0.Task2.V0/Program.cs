using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiui.DanilovAS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DanolovAS.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Александр"));
            Console.ReadKey();
        }
    }
}
