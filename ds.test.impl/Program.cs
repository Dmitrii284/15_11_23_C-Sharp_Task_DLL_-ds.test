

namespace ds.test.impl
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Plugins pluginFactory = new Plugins();
            IPlugin mathPlugin = new MaiPlagin();
            pluginFactory.AddPlugin(mathPlugin);

            string[] pluginNames = pluginFactory.GetPluginNames;
            foreach (string name in pluginNames)
            {
                Console.WriteLine(name);
            }

            IPlugin selectedPlugin = pluginFactory.GetPlugin("MathPlugin");
            if (selectedPlugin != null)
            {
                int result = selectedPlugin.Run(5, 3); // Выполнение операции сложения
                Console.WriteLine("Result: " + result);
            }

            Console.ReadLine();

        }
    }
}