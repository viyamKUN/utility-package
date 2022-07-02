using System.Collections.Generic;
using System.Text;

public static class ListExtensios
{
    /// <summary>
    /// 리스트에서 랜덤한 요소를 가져오기
    /// </summary>
    public static T RandomElement<T>(this List<T> list)
    {
        return list[new System.Random().Next(0, list.Count)];
    }

    /// <returns>리스트의 모든 요소의 ToString</returns>
    public static string ElementsToString<T>(this List<T> list)
    {
        var sb = new StringBuilder();
        foreach (var element in list)
        {
            sb.Append(element.ToString());
            sb.Append("\n");
        }
        return sb.ToString();
    }
}
