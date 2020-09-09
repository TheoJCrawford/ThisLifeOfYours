using System.Collections.Generic;
using System;
using TLY.SkillSystem;

namespace TLY.ItemSystem {
    [Serializable]
    public class Armour:baseItem
    {
        public int ArmourValue { get; internal set; }
        public Dictionary<string, int> reqs { get; internal set; }

        public Armour()
        {
            name = "General clothes";
            ArmourValue = 1;
            coinValue = 5;
            reqs = new Dictionary<string, int>();
        }

        internal void AddRequirement(string name, int level)
        {
            if (Enum.IsDefined(typeof(SkillName), name) && !reqs.ContainsKey(name))
            {
                reqs.Add(name, level);
            }
        }
    }
}
