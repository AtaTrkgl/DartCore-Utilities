using UnityEngine;
using UnityEditor;

namespace DartCore.Utilities
{
    public static class EditorScriptingUtils
    {
        public static void HorizontalLine(int height = 1)
        {
            var color = new Color(.7f, .7f, .7f, 1f);

            Rect rect = EditorGUILayout.GetControlRect(false, height);
            rect.height = height;

            EditorGUI.DrawRect(rect, color);
        }

        public static void HorizontalLine(Color color, int height = 1)
        {
            if (color.Equals(Color.clear))
                color = new Color(.7f, .7f, .7f, 1f);

            Rect rect = EditorGUILayout.GetControlRect(false, height);
            rect.height = height;

            EditorGUI.DrawRect(rect, color);
        }

        /// <summary>
        /// Must be followed by the EndCenter() function.
        /// </summary>
        public static void BeginCenter()
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
        }

        /// <summary>
        /// Must be used after the BeginCenter() function.
        /// </summary>
        public static void EndCenter()
        {
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
    }
}
