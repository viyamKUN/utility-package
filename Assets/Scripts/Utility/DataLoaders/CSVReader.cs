using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Yurei.Utility.DataLoaders
{
    public class CSVReader
    {
        static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
        static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";

        public static List<T> Read<T>(TextAsset asset)
        {
            var list = new List<T>();
            var lines = Regex.Split(asset.text, LINE_SPLIT_RE);

            var header = Regex.Split(lines[0], SPLIT_RE);

            for (int i = 1; i < lines.Length; i++)
            {
                var values = Regex.Split(lines[i], SPLIT_RE);
                if (values.Length == 0 || values[0] == "") continue;

                var entry = System.Activator.CreateInstance<T>();
                for (int j = 0; j < header.Length; j++)
                {
                    var property = entry.GetType().GetProperty(header[j]);
                    var value = values[j];
                    property?.SetValue(entry, value);
                }
                list.Add(entry);
            }
            return list;
        }
    }
}
