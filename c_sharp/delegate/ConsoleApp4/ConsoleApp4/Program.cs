using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    delegate void OutputProcess(string str);

    class DelegateMulti
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }
        
        static void AddQuote(string data)
        {
            Console.WriteLine($" [{data}] ");
        }

        static void Front4(string data)
        {
            Console.WriteLine(data.Substring(0, 4));
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dm = new DelegateMulti();
            OutputProcess proc = AddQuote;
            proc += Front4;
            // proc -= Front4;
            dm.ArrayWalk(data, proc);

        }
    }
}
