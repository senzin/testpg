using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    delegate void OutputProcess(string str);

    class DelegateUseCounter
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }
        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あかまきがみ", "きまきがみ" };

            var du = new DelegateUseCounter();
            var c = new Couter();
            du.ArrayWalk(data, c.AddLenght);
            Console.WriteLine(c.Result);    //結果:17

        }
    }

    class Couter
    {
        public int Result { get; private set; }

        public void AddLenght(string value)
        {
            Result += value.Length;
        }
    }
}
