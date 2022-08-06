using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace DartCore.Utilities
{
    public static class SaveUtilities
    {
        public static void SaveValue<T>(string fileName, T value)
        {
            if (value == null)
                Debug.LogWarning("Tried to save a null value to the \"" + fileName + "\" save file");

            CreateSaveDirectoryIfNecessary(fileName);

            var path = GetPathFromFileName(fileName);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create);

            binaryFormatter.Serialize(stream, value);
            stream.Close();
        }

        public static T ReadValue<T>(string fileName, T defaultValue)
        {
            var path = GetPathFromFileName(fileName);

            if (File.Exists(path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                T value = (T) binaryFormatter.Deserialize(stream);
                stream.Close();

                return value;
            }
            else
            {
                return defaultValue;
            }
        }

        public static void ClearValue(string fileName)
        {
            var path = GetPathFromFileName(fileName);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private static string GetPathFromFileName(string fileName)
        {
            return Application.persistentDataPath + "/saves/" + fileName + ".save";
        }

        private static void CreateSaveDirectoryIfNecessary(string fileName)
        {
            if (!Directory.Exists(Application.persistentDataPath + "/saves"))
                Directory.CreateDirectory(Application.persistentDataPath + "/saves");

            // Create the subdirrectories if there are any.
            if (fileName.Contains("/"))
            {
                var dirs = fileName.Split('/');
                
                // Last index is the name of the file so we skip it.
                for (var i = 0; i < dirs.Length - 1; i++)
                {
                    var currentPathToCheck = Application.persistentDataPath + "/saves";
                    for (var j = 0; j <= i; j++)
                        currentPathToCheck += $"/{dirs[j]}";
                    
                    if (!Directory.Exists(currentPathToCheck))
                        Directory.CreateDirectory(currentPathToCheck);
                }
            }
        }
    }
}
