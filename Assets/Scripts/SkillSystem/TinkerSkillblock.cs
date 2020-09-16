using UnityEngine;

namespace TLY.SkillSystem
{
    public class TinkerSkillblock:SkillBlock
    {
        public TinkerSkillblock()
        {
            name = "Tinker";
            icon = Resources.Load<Sprite>("Asset/Art/SkillIcons/TinkerSkillIcon.png");
            descript = "The construction of new items not commonly used.";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
