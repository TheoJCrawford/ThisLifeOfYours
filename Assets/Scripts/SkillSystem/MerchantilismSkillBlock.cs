using UnityEngine;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    class MerchantilismSkillBlock:SkillBlock
    {
        public MerchantilismSkillBlock()
        {
            name = "Merchantilism";
            descript = "The ability to barter better.";
            icon = Resources.Load<Sprite>("Asset/");
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
