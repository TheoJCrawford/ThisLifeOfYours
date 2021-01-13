using System;
using System.Collections.Generic;

namespace TLY.TownActivities.NPC
{
    public class StoreFront:NPCCore
    {
        public string ExitStore { get; set; }

        public StoreFront()
        {
            ExitStore = "Thank you for coming. See you next time.";
        }
    }
}
