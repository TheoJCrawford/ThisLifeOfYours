using UnityEditor;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class ThaumatergySkillblock:SkillBlock
    {
        public ThaumatergySkillblock()
        {
            name = "Thamatergy";
            descript = "The construction of aether manipulating gear as well as research";
            icon = (Image)AssetDatabase.LoadAssetAtPath("",typeof(Image));
        }
    }
}
