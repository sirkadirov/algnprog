using PluginSystemLib;
using ProgrammingLab.Labs.Lab2;

namespace Lab2
{
    public class Lab2 : PluginBase
    {

        public override string GetPluginName()
        {
            return "Знаходження положення точки відносно трикутника";
        }

        public override void ExecutePlugin()
        {
            _ = new LabWnd2().ShowDialog();
        }

    }

}
