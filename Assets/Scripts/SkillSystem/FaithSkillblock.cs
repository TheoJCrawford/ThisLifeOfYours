using UnityEngine;
namespace TLY.SkillSystem
{
    public class FaithSkillblock:SkillBlock
    {
        public FaithSkillblock()
        {
            name = "Faith";
            icon = Resources.Load<Sprite>("Asset/Art/SkillIcons/ThieverySkillIcon.png");
            descript = "Stealing and moving quietly on the job.";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
