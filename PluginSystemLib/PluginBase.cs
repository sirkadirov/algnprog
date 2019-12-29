using System;

namespace PluginSystemLib
{

    public class PluginBase
    {

        public virtual string GetPluginName()
        {
            throw new NotImplementedException();
        }

        public virtual void ExecutePlugin()
        {
            throw new NotImplementedException();
        }

    }

}
