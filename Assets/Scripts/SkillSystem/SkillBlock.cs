using UnityEngine;

namespace TLY.SkillSystem
{
    public class SkillBlock
    {
        private const int LEVEL_CAP = 10;
        private const int BROKEN_CAP = 20;

        public int skillID { get; protected set; }
        public int level { get; protected set; }
        public bool limitBroken { get; protected set; }

        public int expToLvel { get; protected set; }
        public int expPool { get; protected set; }
        public int exhaust { get; protected set; }

        public SkillBlock(int SID = 0)
        {
            skillID = SID;
            level = 0;
            limitBroken = false;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }

        public void GainExperience(int Val)
        {
            if(exhaust > 0)
            {
                expPool += Val / exhaust + 1;
            }
            else
            {
                expPool += Val;
            }
            if(expPool >= expToLvel)
            {
                LevelUp();
            }
        }
        private void LevelUp()
        {
            level++;
            expToLvel += level * 1000;
        }
        public void IncreaseExhaust() => exhaust++;
        public void ResetExhaust() => exhaust = 0;
        public void BreakTheLimit() => limitBroken = true;
        
    }
}
