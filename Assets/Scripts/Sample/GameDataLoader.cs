using UnityEditor;
using UnityEngine;

namespace Yurei.Sample
{
    using Utility.DataLoaders;

    public class GameDataLoader : MonoBehaviour
    {
        private const string _PATH = "csvSample";

        public void LoadCSV()
        {
            var asset = Resources.Load<TextAsset>(_PATH);
            var data = CSVReader.Read<Item>(asset);
            Debug.Log(data.ElementsToString());
        }
    }


    [CustomEditor(typeof(GameDataLoader))]
    public class GameDataLoaderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Load sample CSV"))
            {
                (target as GameDataLoader).LoadCSV();
            }
        }
    }
}
