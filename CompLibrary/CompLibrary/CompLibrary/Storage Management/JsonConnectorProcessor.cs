﻿using System;
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
        public static string getFilePath(this string FileName)

        => $"{GlobalConfig.getAppDirectory()}\\JsonStorage\\{FileName}";


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
        public static void createFileIfNull(this string fileName)
        {
            string path = getFilePath(fileName);

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
        public static void createFileIfNull<T>(this string fileName, T defaultValues)
        {
            string path = getFilePath(fileName);

            if (!File.Exists(path))
            {
                string defaultText = JsonConvert.SerializeObject(defaultValues);
                File.WriteAllText(path, defaultText);
            }
        }

        /// <summary>
        /// Serializes variable or connection for writing to disk.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string getJsonString<T>(this T data) => JsonConvert.SerializeObject(data);

        /// <summary>
        /// Writes all data given as parameter to the path that it is appended to.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        public static void writeToFile(this string path, string data)
        {
            File.WriteAllText(path, data);
        }

        /// <summary>
        /// Reads all text from file to param string
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string readFromFile(this string path) => File.ReadAllText(path);

        /// <summary>
        /// Deserializes data given as parameter to indicated type
        /// </summary>
        /// <typeparam name="T">Type to deserialize to</typeparam>
        /// <param name="data">String that contains serialized data</param>
        /// <returns></returns>
        public static T deserializeData<T>(this string data) => JsonConvert.DeserializeObject<T>(data);
    }
}
