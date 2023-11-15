using ds.test.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public class MaiPlagin : IPlugin
    {        
            public string PluginName { get { return "MathPlugin"; } }
            public string Version { get { return "1.0"; } }
            public string Description { get { return "Plugin for mathematical operations"; } }

            public int Run(int input1, int input2)
            {
                return input1 + input2; // Пример реализации сложения (можно добавить другие операции)
            }
        
    }
}
