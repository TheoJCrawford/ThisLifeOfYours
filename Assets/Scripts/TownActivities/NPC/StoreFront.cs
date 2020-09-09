using System;
using System.Collections.Generic;
using TLY.ItemSystem;

namespace TLY.TownActivities.NPC
{
    public class StoreFront:NPCCore
    {
        public List<baseItem> storefront { get; set; }
        public string ExitStore { get; set; }

        public StoreFront()
        {
            storefront = new List<baseItem>();
            ExitStore = "Thank you for coming. See you next time.";
        }
    }
}
