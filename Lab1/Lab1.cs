using PluginSystemLib;
using ProgrammingLab.Labs.Lab1;

namespace Lab1
{
    public class Lab1 : PluginBase
    {

        public override string GetPluginName()
        {
            return "Знаходження коренів квадратних рівнянь";
        }

        public override void ExecutePlugin()
        {
            _ = new LabWnd1().ShowDialog();
        }

    }

}
