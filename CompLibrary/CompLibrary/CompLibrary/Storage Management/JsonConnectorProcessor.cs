using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace CompLibrary
{
    public static class JsonConnectorProcessor
    {
        /// <summary>
        /// returns file path of a .json file
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static string GetFilePath(this string FileName)
        {
            return $"{GlobalConfig.getAppDirectory()}\\JsonStorage\\{FileName}";
        }

        /// <summary>
        /// Checks if required json app folders exist and creates them if needed
        /// </summary>
        public static void createJsonDirectories()
        {
            //checks if main app directory exists
            if (!Directory.Exists(GlobalConfig.getAppDirectory()))
            {
                Directory.CreateDirectory(GlobalConfig.getAppDirectory());
            }
            //checks if json storage directory exists
            if (!Directory.Exists($"{GlobalConfig.getAppDirectory()}\\jsonStorage"))
            {
                Directory.CreateDirectory($"{GlobalConfig.getAppDirectory()}\\jsonStorage");
            }
        }


        /// <summary>
        /// Creates Json file with specified name if it does not exist
        /// </summary>
        /// <param name="fileName">name of the file to check</param>
        public static void createFileIfNull(string fileName)
        {
            string path = GetFilePath(fileName);

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
            }
        }

        /// <summary>
        /// Overload. Creates Json file with specified name if it does not exist and fills it with data
        /// </summary>
        /// <typeparam name="T">template for default data</typeparam>
        /// <param name="fileName">name of the file to write to</param>
        /// <param name="defaultValues">default data structure</param>
        public static void createFileIfNull<T>(string fileName, T defaultValues)
        {
            string path = GetFilePath(fileName);

            if (!File.Exists(path))
            {
                string defaultText = JsonConvert.SerializeObject(defaultValues);
                File.WriteAllText(path, defaultText);
            }
        }
    }
}
