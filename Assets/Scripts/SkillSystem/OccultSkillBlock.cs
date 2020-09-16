using UnityEngine;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class OccultSkillBlock:SkillBlock
    {
        public OccultSkillBlock()
        {
            name = "Occultism";
            descript = "With eldritch horrors, create and destroy";
            icon = Resources.Load<Sprite>("Asset/Art/Skill Icons/OccultIcon.png");
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
