using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLY.SkillSystem
{
    public class PerformanceSkillBlock:SkillBlock
    {
        public PerformanceSkillBlock()
        {
            name = "Performance";
            descript = "Singing in bars, acting on the stage.";
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }
    }
}
