public static class Debug
{
    public static void Log(string log)
    {
#if RELEASE
#elif EDITOR
        UnityEngine.Debug.Log(log);
#endif
    }

    /// <param name="color">hex코드이거나 특정 색 이름.</param>
    public static void Log(string log, string color)
    {
#if RELEASE
#elif EDITOR
        UnityEngine.Debug.Log($"<color={color}>{log}</color>");
#endif
    }

    public static void LogError(string log)
    {
        UnityEngine.Debug.LogError(log);
    }

    public static void LogWarning(string log)
    {
        UnityEngine.Debug.LogWarning(log);
    }
}
