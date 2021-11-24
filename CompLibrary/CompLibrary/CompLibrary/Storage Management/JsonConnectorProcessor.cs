using System.IO;
using Newtonsoft.Json;

namespace CompLibrary
{
    public static class JsonConnectorProcessor
    {
        public static readonly string AppDirectory = FunctionLibrary.GetAppDirectory();
        public static readonly string JsonDirectory = $"{AppDirectory}\\jsonStorage";
        public static readonly string BackupDirectory = $"{JsonDirectory}\\backup";
        /// <summary>
        /// returns file path of a .json file
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>

        /// <summary>
        /// Checks if required json app folders exist and creates them if needed
        /// </summary>
        public static void CreateJsonDirectories()
        {
            //checks if main app directory exists
            if (!Directory.Exists(AppDirectory))
            {
                Directory.CreateDirectory(AppDirectory);
            }

            if (!Directory.Exists(JsonDirectory))
            {
                Directory.CreateDirectory(JsonDirectory);
            }

            if (!Directory.Exists(BackupDirectory))
            {
                Directory.CreateDirectory(BackupDirectory);
            }
        }


        /// <summary>
        /// Creates Json file at the specified path if it does not exist.
        /// </summary>
        /// <param name="filePath">path of the file to check</param>
        public static void CreateFileIfNull(this string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

        /// <summary>
        /// Overload. Creates Json file at the specified path if it does not exist and fills it with data given as parameter.
        /// </summary>
        /// <typeparam name="T">template for default data</typeparam>
        /// <param name="filePath">path of the file to write to</param>
        /// <param name="defaultValues">default data structure</param>
        public static void CreateFileIfNull<T>(this string filePath, T defaultValues)
        {
            if (!File.Exists(filePath))
            {
                string defaultText = JsonConvert.SerializeObject(defaultValues);
                File.WriteAllText(filePath, defaultText);
            }
        }

        /// <summary>
        /// Serializes variable or connection for writing to disk.
        /// </summary>
        public static string GetJsonString<T>(this T data) => JsonConvert.SerializeObject(data);

        /// <summary>
        /// Writes all data given as parameter to the path that it is appended to.
        /// </summary>
        public static void WriteToFile(this string path, string data)
        {
            File.WriteAllText(path, data);
        }

        /// <summary>
        /// Reads all text from file to param string
        /// </summary>
        public static string ReadFromFile(this string path) => File.ReadAllText(path);

        /// <summary>
        /// Deserializes data given as parameter to indicated type
        /// </summary>
        /// <typeparam name="T">Type to deserialize to</typeparam>
        /// <param name="data">String that contains serialized data</param>
        public static T DeserializeData<T>(this string data) => JsonConvert.DeserializeObject<T>(data);
    }
}
