using System.Text;

public static class ArrayExtensions
{
    /// <returns>array의 모든 요소의 ToString</returns>
    public static string ElementsToString<T>(T[] array)
    {
        var sb = new StringBuilder();
        foreach (var element in array)
        {
            sb.Append(element.ToString());
            sb.Append("\n");
        }
        return sb.ToString();
    }
}
