using DSP.CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculatorService = new CalculatorService();

            int res = calculatorService.Add(1, 2);
            int res2 = calculatorService.Add(3, res);

            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}
