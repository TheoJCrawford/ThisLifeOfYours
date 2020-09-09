using System;
using System.Collections.Generic;
using TLY.SkillSystem;

namespace TLY.ItemSystem
{
    [Serializable]
    public class Weapon:baseItem
    {
        public int Damage { get; set; }
        public string AnimationType { get; set; }
        public Dictionary<string, int> reqs { get; internal set; }

        public Weapon()
        {
            name = "Fists";
            descript = "These are your bare fists.";
            coinValue = 0;
            Damage = 5;
            AnimationType = "Punching";
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
