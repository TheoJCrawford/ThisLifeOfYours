using UnityEngine;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class ThieverySkilBlock:SkillBlock
    {
        public ThieverySkilBlock()
        {
            name = "Thievery";
            icon = Resources.Load<Sprite>("Asset/Art/SkillIcons/ThieverySkillIcon.png");
            descript = "Stealing and moving quietly on the job.";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
