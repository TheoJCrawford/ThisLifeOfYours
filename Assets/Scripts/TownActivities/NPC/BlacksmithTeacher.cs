using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLY.SkillSystem;

namespace TLY.TownActivities.NPC
{
    class BlacksmithTeacher:SkillTrainer
    {
        public BlacksmithTeacher()
        {
            skillTeacher = new SmithingSkillBlock();
        }
    }
}
