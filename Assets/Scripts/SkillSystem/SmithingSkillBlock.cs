using UnityEngine;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class SmithingSkillBlock : SkillBlock
    {
        public SmithingSkillBlock()
        {
            name = "Smithing";
            icon = Resources.Load<Sprite>("Asset/Art/Skill Icons/SmithingSkillIcon.png");
            descript = "The ability to craft most weapons and armour, as well as some ammunition";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
