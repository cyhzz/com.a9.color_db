using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
namespace Com.A9.ColorDB
{
    public class ColorWindow : EditorWindow
    {
        static ColorConfig color_config;

        [MenuItem("DB/Color", false, 0)]
        public static void ShowWindow()
        {
            GetWindow<ColorWindow>(false, "Color", true);
            color_config = Resources.Load<ColorConfig>("colors");
        }
        Vector2 scroll_pos;
        private void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            for (int i = 0; i < color_config.color_list.Count; i++)
            {
                EditorGUILayout.BeginHorizontal();
                color_config.color_list[i].name = EditorGUILayout.TextArea(color_config.color_list[i].name);
                color_config.color_list[i].col = EditorGUILayout.ColorField(color_config.color_list[i].col);
                EditorGUILayout.EndHorizontal();
            }
            if (GUILayout.Button("create", GUILayout.Width(120), GUILayout.Height(30)))
                color_config.color_list.Add(new ColorDic() { name = "white", col = Color.white });
            EditorGUILayout.EndVertical();
            EditorUtility.SetDirty(color_config);
        }
    }

}
