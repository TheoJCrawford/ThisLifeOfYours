using UnityEngine;

namespace TLY.ItemSystem
{
    public class Clothing:EquipableObject
    {
        [SerializeField] private string _clothAnimId;
        public Clothing()
        {
            base.ChangeItemType(ItemType.Equipment);
            base.SetEquipType(EquiableType.Body);
        }
    }
}
