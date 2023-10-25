using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_OOPA_2324_ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass1 sc1 = new SampleClass1();
            Console.WriteLine(sc1.message());
            sc1.changeTheMessage("This is the new message");
            Console.WriteLine(sc1.message());
            Console.ReadKey();
        }
    }
}
