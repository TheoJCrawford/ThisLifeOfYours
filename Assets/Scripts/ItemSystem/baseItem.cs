using System;
using System.Diagnostics;
using UnityEngine;
namespace TLY.ItemSystem
{
    [Serializable]
    public class baseItem:ScriptableObject
    {
        public string name { get;  set; }
        public Sprite icon { get;  private set; }
        public string descript { get;  set; }
        public int coinValue { get;  set; }

        public baseItem()
        {
            name = "Iron Ore";
            descript = "This is a piece of Iron Ore";
            coinValue = 5;
        }
        public void ChangeIcon(Sprite NewImage)
        {
            icon = NewImage;
        }
    }
}