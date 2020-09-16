using UnityEngine;

namespace TLY.SkillSystem
{
    public class AlechemySkillblock:SkillBlock
    {
        public AlechemySkillblock()
        {
            name = "Alchemy";
            icon = Resources.Load<Sprite>("Asset/Art/Skill Icons/AlchemySkilIcon.png");
            descript = "The ability to make potions and poisons";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
