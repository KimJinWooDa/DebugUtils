using System.Diagnostics;
using UnityEngine;

namespace DebugHelper
{
    public static class Debug
    {
        private static string BuildPrefix(int? prefixNumber, string tag, bool showTimestamp)
        {
            string ts = showTimestamp ? $"[{System.DateTime.Now:HH:mm:ss}] " : "";
            string t = string.IsNullOrEmpty(tag) ? "" : $"[{tag}] ";
            string n = prefixNumber.HasValue ? $"{prefixNumber.Value}. " : "";
            return ts + t + n;
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogColor(string message, Color color, int? prefixNumber = null, string tag = null, bool showTimestamp = false)
        {
            string prefix = BuildPrefix(prefixNumber, tag, showTimestamp);
            string output = $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{prefix}{message}</color>";
            UnityEngine.Debug.Log(output);
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogColorPart(string message, string part, Color color, int? prefixNumber = null, string tag = null, bool showTimestamp = false)
        {
            string prefix = BuildPrefix(prefixNumber, tag, showTimestamp);
            string coloredPart = $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{part}</color>";
            string output = (prefix + message).Replace(part, coloredPart);
            UnityEngine.Debug.Log(output);
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogColorWarning(string message, Color color, int? prefixNumber = null, string tag = null, bool showTimestamp = false)
        {
            string prefix = BuildPrefix(prefixNumber, tag, showTimestamp);
            string output = $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{prefix}{message}</color>";
            UnityEngine.Debug.LogWarning(output);
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogColorError(string message, Color color, int? prefixNumber = null, string tag = null, bool showTimestamp = false)
        {
            string prefix = BuildPrefix(prefixNumber, tag, showTimestamp);
            string output = $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{prefix}{message}</color>";
            UnityEngine.Debug.LogError(output);
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogIf(bool condition, string message, Color color, int? prefixNumber = null, string tag = null, bool showTimestamp = false)
        {
            if (!condition) return;
            LogColor(message, color, prefixNumber, tag, showTimestamp);
        }
    }
}
