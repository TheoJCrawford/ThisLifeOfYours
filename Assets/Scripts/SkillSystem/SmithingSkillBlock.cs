using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class SmithingSkillBlock : SkillBlock
    {
        public SmithingSkillBlock()
        {
            name = "Smithing";
            icon = (Image)UnityEditor.AssetDatabase.LoadAssetAtPath("Asset/Art/Skill Icons/SmithingSkillIcon.png", typeof(Image));
            descript = "The ability to craft most weapons and armour, as well as some ammunition";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
