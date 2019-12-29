using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginSystemLib;

namespace Lab6_2
{
    public class Lab6_2 : PluginBase
    {

        public override string GetPluginName()
        {
            return "Розв'язання СЛАР методами Гауса та Крамера";
        }

        public override void ExecutePlugin()
        {
            new LabWnd6_2().ShowDialog();
        }

    }

}
