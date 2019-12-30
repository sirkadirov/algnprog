using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginSystemLib;

namespace LabNumbers
{

    public class LabNumbers : PluginBase
    {

        public override string GetPluginName()
        {
            return "Перестановка цифр у 4-х значному числі";
        }

        public override void ExecutePlugin()
        {

            Console.WriteLine("Enter number:");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num < 1000 || num > 9999)
            {
                Console.WriteLine("Number must be >= 1000 and <= 9999!");
            }

            var part1 = num / 1000;
            var part2 = (num - (part1 * 1000)) / 100;
            var part3 = (num - (part1 * 1000 + part2 * 100)) / 10;
            var part4 = num % 10;

            Console.WriteLine($"[1]: {part1}\r\n[2]: {part2}\r\n[3]: {part3}\r\n[4]: {part4}");

            Console.WriteLine(part1 * 1000 + part3 * 100 + part2 * 10 + part4);

        }

    }

}
