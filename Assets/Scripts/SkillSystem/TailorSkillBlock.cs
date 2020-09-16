using UnityEngine;
namespace TLY.SkillSystem
{
    public class TailorSkillBlock:SkillBlock
    {
        public TailorSkillBlock()
        {
            name = "Tailor";
            descript = "For the making of clothing and other wares";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
