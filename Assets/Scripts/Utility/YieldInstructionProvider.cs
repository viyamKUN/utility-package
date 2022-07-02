using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 유니티 코루틴에서 사용하는 지시문 제공자.
/// </summary>
public static class YieldInstructionProvider
{
    private static Dictionary<float, WaitForSeconds> _waitForSeconds = new Dictionary<float, WaitForSeconds>();
    private static Dictionary<float, WaitForSecondsRealtime> _waitForSecondsRealtime = new Dictionary<float, WaitForSecondsRealtime>();

    public static WaitForSeconds WaitForSeconds(float sec)
    {
        if (_waitForSeconds.ContainsKey(sec))
        {
            return _waitForSeconds[sec];
        }
        var instruction = new WaitForSeconds(sec);
        _waitForSeconds.Add(sec, instruction);
        return instruction;
    }

    public static WaitForSecondsRealtime WaitForSecondsRealtime(float sec)
    {
        if (_waitForSecondsRealtime.ContainsKey(sec))
        {
            return _waitForSecondsRealtime[sec];
        }
        var instruction = new WaitForSecondsRealtime(sec);
        _waitForSecondsRealtime.Add(sec, instruction);
        return instruction;
    }
}
