using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Reflection;
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
                var properties = entry.GetType().GetProperties();
                for (int j = 0; j < header.Length; j++)
                {
                    var property = properties.First(x =>
                    {
                        var csvProp = x.GetCustomAttribute(typeof(CSVPropertyAttribute)) as CSVPropertyAttribute;
                        return csvProp.PropertyName.Equals(header[j]);
                    });

                    // Try parse
                    object value = values[j];
                    if (int.TryParse(values[j], out int intValue))
                        value = intValue;
                    else if (float.TryParse(values[j], out float floatValue))
                        value = floatValue;

                    property?.SetValue(entry, value);
                }
                list.Add(entry);
            }
            return list;
        }
    }
}
