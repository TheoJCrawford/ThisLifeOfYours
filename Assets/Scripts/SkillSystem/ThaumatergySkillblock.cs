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
            icon = (Image)AssetDatabase.LoadAssetAtPath("Asset/Art/SkillIcons/ThaumaterySkillIcon.png",typeof(Image));
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
