using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate void OutputProcess(string str);

    class DelegateUse
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                //デリゲートの呼び出し
                output(value);
            }
        }

        //OutputProcess型に対応したメソッド
        static void AddQuote(string data)
        {
            Console.WriteLine($" [{data}]");
        }

        static void Main(string[] args)
        {
            //文字列配列dataの内容を順に出力
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegateUse();
            OutputProcess proc = AddQuote;
            du.ArrayWalk(data, proc);
        }
    }
}
