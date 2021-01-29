using UnityEngine;
namespace TLY.ItemSystem
{
    public class EquipableObject:ItemCore
    {
        public enum EquiableType {Hand, Head, Body, Accessory };

        [SerializeField] private EquiableType _equipType;


        public EquiableType EquipType => _equipType;

        internal void SetEquipType(EquiableType val)
        {
            _equipType = val;
        }
        public EquipableObject()
        {
            ChangeItemType(ItemType.Equipment);
        }
    }
}
