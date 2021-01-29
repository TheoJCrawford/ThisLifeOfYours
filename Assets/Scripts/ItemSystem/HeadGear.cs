using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLY.ItemSystem
{
    public class HeadGear:EquipableObject
    {
        public HeadGear()
        {
            ChangeItemType(ItemType.Equipment);
            SetEquipType(EquiableType.Head);
        }
    }
}
