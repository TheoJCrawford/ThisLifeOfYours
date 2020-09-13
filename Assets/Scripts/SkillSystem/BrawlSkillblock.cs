﻿using UnityEngine;
using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class BrawlSkillblock:SkillBlock
    {
        public BrawlSkillblock()
        {
            name = "Brawling";
            icon = Resources.Load<Image>("Asset/Art/Skill Icons/BrawlingSkillIcon.png");
            descript = "The application of fist to other's faces.";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
