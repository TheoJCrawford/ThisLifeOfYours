using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class BrawlSkillblock:SkillBlock
    {
        public BrawlSkillblock()
        {
            name = "Brawling";
            icon = (Image)AssetDatabase.LoadAssetAtPath("Asset/Art/Skill Icons/BrawlingSkillIcon.png",typeof(Image));
            descript = " ";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
