using PluginSystemLib;

namespace Lab11
{

    class Lab11 : PluginBase
    {

        public override string GetPluginName()
        {
            return "Приблизне обчислення визначеного інтегралу користувацької функції";
        }

        public override void ExecutePlugin()
        {
            new LabWnd11().ShowDialog();
        }

    }

}
