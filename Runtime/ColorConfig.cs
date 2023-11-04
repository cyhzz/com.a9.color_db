using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.A9.ColorDB
{
    [CreateAssetMenu(menuName = "My Assets/ColorConfig")]
    public class ColorConfig : ScriptableObject
    {
        public List<ColorDic> color_list;
    }
}

