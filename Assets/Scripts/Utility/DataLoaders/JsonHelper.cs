using UnityEngine;

namespace Yurei.Utility.DataLoaders
{
    public class JsonHelper
    {
        public static T[] GetJsonArray<T>(string text)
        {
            return JsonUtility.FromJson<Wrapper<T>>(text).array;
        }

        private class Wrapper<T>
        {
            public T[] array;
        }
    }
}
