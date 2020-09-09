using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class BrawlSkillblock:SkillBlock
    {
        public BrawlSkillblock()
        {
            name = "Brawling";
            icon = (Image)UnityEditor.AssetDatabase.LoadAssetAtPath("Asset/Art/Skill Icons/BrawlingSkillIcon.png",typeof(Image));
            descript = "The application of fist to other's faces.";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
