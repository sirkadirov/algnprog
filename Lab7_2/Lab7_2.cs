using PluginSystemLib;
using ProgrammingLab.Labs.Lab7;

namespace Lab7_2
{
    public class Lab7_2 : PluginBase
    {

        public override string GetPluginName()
        {
            return "Побудова графіків користувацьких функцій на основі компоненту Chart";
        }

        public override void ExecutePlugin()
        {
            _ = new LabWnd7().ShowDialog();
        }

    }

}
