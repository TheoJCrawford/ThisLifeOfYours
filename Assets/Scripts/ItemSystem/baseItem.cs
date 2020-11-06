using System;
using System.Diagnostics;
using UnityEngine;
namespace TLY.ItemSystem
{
    [Serializable]
    public class baseItem:ScriptableObject
    {
        [SerializeField]
        
        public string itemName { get;  set; }
        public Sprite icon { get;  private set; }
        public string descript { get;  set; }
        public int coinValue { get;  set; }

        public baseItem()
        {
            itemName = "Iron Ore";
            descript = "This is a piece of Iron Ore";
            coinValue = 5;
        }
        public void ChangeIcon(Sprite NewImage)
        {
            icon = NewImage;
        }
    }
}