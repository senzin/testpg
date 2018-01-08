using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DeleegateNoUse
    {
         void ArrayWalk(string[] data)
        {
            foreach (var value in data)
            {
                Console.WriteLine($" [{ value}] ");
            }
        }
        static void Main(string[] args)
        {
            //文字列配列dataの内容を順に出力
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var nu = new DeleegateNoUse();
            nu.ArrayWalk(data);
        }
    }
}
