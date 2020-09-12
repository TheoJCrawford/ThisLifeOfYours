using UnityEngine.UI;
using UnityEditor;
namespace TLY.SkillSystem
{
    public class FaithSkillblock:SkillBlock
    {
        public FaithSkillblock()
        {
            name = "Faith";
            icon = (Image)AssetDatabase.LoadAssetAtPath("Asset/Art/SkillIcons/ThieverySkillIcon.png", typeof(Image));
            descript = "Stealing and moving quietly on the job.";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
