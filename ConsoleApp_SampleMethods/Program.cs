using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SampleMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program objProg = new Program();

            objProg.SampleMethod = (); //Call object method

            SampleMethod(); // Call static method
        }
        static void SampleMethod()
        {
            Console.WriteLine("I'm hugry");
            Console.ReadKey();
        }
    }
}
