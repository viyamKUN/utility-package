using UnityEditor;
using UnityEngine;

namespace Yurei.Sample
{
    using Utility.DataLoaders;

    public class GameDataLoader : MonoBehaviour
    {
        private const string _CSV_PATH = "csvSample";
        private const string _JSON_PATH = "jsonSample";

        public void LoadCSV()
        {
            var asset = Resources.Load<TextAsset>(_CSV_PATH);
            var data = CSVReader.Read<CsvItem>(asset);
            Debug.Log(data.ElementsToString());
        }

        public void LoadJson()
        {
            var asset = Resources.Load<TextAsset>(_JSON_PATH);
            var data = JsonHelper.GetJsonArray<JsonItem>(asset.text);
            Debug.Log(ArrayExtensions.ElementsToString(data));
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
            if (GUILayout.Button("Load sample JSON"))
            {
                (target as GameDataLoader).LoadJson();
            }
        }
    }
}
