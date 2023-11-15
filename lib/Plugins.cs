using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public class Plugins : IPluginFactory
    {
        private List<IPlugin> plugins;
        public Plugins() { plugins = new List<IPlugin>(); }
        public int PluginsCount
        {
            get { return plugins.Count; }
        }
        public string[] GetPluginNames 
        {
            get
            {
                List<string> names = new List<string>();
                foreach(IPlugin plugin in plugins)
                {
                    names.Add(plugin.PluginName);
                }
                return names.ToArray();
            }
        }

        public void AddPlugin(IPlugin plugin)
        {
            plugins.Add(plugin);
        }

           public IPlugin GetPlugin(string pluginName)
           {
            foreach(IPlugin plugin in plugins)
            {
                return plugin;
            }
            return null;
           }        

    }
}
