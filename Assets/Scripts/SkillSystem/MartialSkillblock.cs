using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class MartialSkillblock:SkillBlock
    { 
        public MartialSkillblock()
        {
            name = "Martial";
            descript = "Weapons and armour, the skills of war.";
            icon = (Image)AssetDatabase.LoadAssetAtPath("Assets/Art/SkillIcons/MartialSkillIcon.png", typeof(Image));
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
