using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.A9.ColorDB
{
    [System.Serializable]
    public class ColorDic
    {
        public string name;
        [ColorUsage(false)]
        public Color col;
    }
    public class ColorPicker : MonoBehaviour
    {
        public static Dictionary<string, Color> colors;
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Init()
        {
            colors = new Dictionary<string, Color>();
            ColorConfig config = Resources.Load<ColorConfig>("colors");
            for (int i = 0; i < config.color_list.Count; i++)
                colors.Add(config.color_list[i].name, config.color_list[i].col);
        }
    }
}

