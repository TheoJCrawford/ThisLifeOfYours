using UnityEngine;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class LeatherworkSkillBlock:SkillBlock
    {
        public LeatherworkSkillBlock()
        {
            name = "Leatherworking";
            descript = "The ability to make some armours and shoes";
            icon = Resources.Load<Sprite>("Asset/Art/Skill Icons/LeatherworkIcon.png");
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
