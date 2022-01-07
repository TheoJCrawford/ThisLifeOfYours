using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TLY.ItemSystem
{
    [RequireComponent(typeof(ChestAnimator))]
    public class ChestInventory : Chest
    {
        [SerializeField] private Inventory Inventory = Inventory.CreateNewInventory();

        public new void OpenChest()
        {
            base.OpenChest();
        }
    }
}