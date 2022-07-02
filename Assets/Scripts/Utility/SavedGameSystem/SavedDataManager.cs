using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Yurei.Utility.SavedGameSystem
{
    public static class SavedDataManager
    {
        private static string SaveFileName = $"{Application.persistentDataPath}/{"gamedata.save"}";
        private static SavedData _myData;
        public static SavedData MyData
        {
            get => _myData;
        }

        public static void Init()
        {
            _myData = new SavedData("test");
            Save();
        }

        public static void Save()
        {
            using (var file = File.Create(SaveFileName))
                new BinaryFormatter().Serialize(file, _myData);
        }

        public static bool Load()
        {
            if (File.Exists(SaveFileName))
            {
                using (var file = File.Open(SaveFileName, FileMode.Open))
                {
                    if (file != null && file.Length > 0)
                    {
                        _myData = new BinaryFormatter().Deserialize(file) as SavedData;
                        return true;
                    }
                }
            }
            return false;
        }

        public static void Delete()
        {
            File.Delete(SaveFileName);
        }
    }
}
