using System.Collections.Generic;


namespace TLY.ItemSystem
{
    public class Recipe
    {
        public string SkillNeeded;
        public int levelReq { get; internal set; }
        public Dictionary<string, int> itemsNeeded;
            public string returningItem;
        public int returningNumber;

        internal bool _canbeHQ;

        public Recipe()
        {
            SkillNeeded = "Smithing";
            levelReq = 1;
            itemsNeeded = new Dictionary<string, int>();
            
            returningNumber = 1;
            _canbeHQ = false;
        }
    }
}
