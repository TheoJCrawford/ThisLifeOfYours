using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TLY.ItemSystem
{
    [CreateAssetMenu(fileName = "New Armor", menuName ="TLY/Items/New Armor")]
    public class ArmorClothing:EquipableObject
    {
        [SerializeField] private int _defense;
        [SerializeField] private int _speed;

        public int defence => _defense;
        public int speed => _speed;

        public ArmorClothing()
        {
            ChangeItemType(ItemType.Equipment);
            SetEquipType(EquiableType.Body);
        }
    }
}
