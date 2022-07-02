using UnityEditor;
using UnityEngine;

namespace Yurei.Sample
{
    using Utility.SavedGameSystem;
    public class UserDataLoader : MonoBehaviour
    {
        public void LoadData()
        {
            var success = SavedDataManager.Load();
            if (success)
            {
                Debug.Log("Load Complete", "green");
            }
            else
            {
                SavedDataManager.Init();
                Debug.Log("Initialize Data", "orange");
            }
            var user = SavedDataManager.MyData.UserName;
            Debug.Log($"Hi, {user}.");
        }

        public void DeleteData()
        {
            SavedDataManager.Delete();
            Debug.Log("Delete Complete", "red");
        }
    }


    [CustomEditor(typeof(UserDataLoader))]
    public class UserDataLoaderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Load Data"))
            {
                (target as UserDataLoader).LoadData();
            }
            if (GUILayout.Button("Delete Data"))
            {
                (target as UserDataLoader).DeleteData();
            }
        }
    }
}
