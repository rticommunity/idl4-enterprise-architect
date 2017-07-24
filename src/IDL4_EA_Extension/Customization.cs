using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDL4_EA_Extension
{
    public class Customization
    {
        public Customization()
        {
            string dllPath = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            string assemblyFolder = System.IO.Path.GetDirectoryName(dllPath);
            configFilePath = System.IO.Path.Combine(assemblyFolder, "IDL4GeneratorConfig.txt");
        }

        public string getConfigFilePath()
        {
            return configFilePath;
        }

        public string getParseResult()
        {
            return parseResult;
        }

        public bool ParseConfigFile()
        {
            String line;
            System.IO.StreamReader file = null;

            try
            {
                file = new System.IO.StreamReader(configFilePath);

                while ((line = file.ReadLine()) != null)
                {
                    /* Process Line*/
                }

                // parseResult == null indicates successful parsing
                parseResult = null;
                return true;
            }
            catch (System.IO.FileNotFoundException)
            {
                parseResult = "Cannot find file \"" + configFilePath + "\"";
            }
            catch ( Exception )
            {
                parseResult = "Cannot open file \"" + configFilePath + "\"";
            }

            return false;
        }

        private string configFilePath;
        private string parseResult = "Customization file not parsed";
    }
}
