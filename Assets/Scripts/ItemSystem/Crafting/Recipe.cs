using System;
using System.Collections.Generic;
using UnityEngine;

namespace TLY.ItemSystem
{
    [Serializable]
    public class Recipe
    {
        [SerializeField] public int levelReq { get; internal set; }
        [SerializeField] public int staminaDrain { get; internal set; }
        [SerializeField] public Dictionary<int, int> itemsNeeded { get; set; }
        [SerializeField] public int returningNumber;
        [SerializeField] public baseItem _output;

        [SerializeField]public bool _canbeHQ;

        public Recipe()
        {
            levelReq = 1;
            staminaDrain = 5;
            itemsNeeded = new Dictionary<int, int>();
            returningNumber = 1;
            _output = new baseItem();
            _canbeHQ = false;
        }
        
        public Recipe(int LvlRq, int[] Component, int[] Req, baseItem Output, int Returning, bool HQ)
        {
            levelReq = LvlRq;
            itemsNeeded = new Dictionary<int, int>();
            foreach(int i in Component)
            {
                itemsNeeded.Add(Component[i], Req[i]);
            }
            _output = Output;
            returningNumber = Returning;
            _canbeHQ = HQ;
            staminaDrain = 1;
        }

        #region Editor
        public void AddToItemsNeeded(int itemName, int value)
        {
            if (!itemsNeeded.ContainsKey(itemName))
            {
                itemsNeeded.Add(itemName, value);
            }
        }
        public void SetStaminaDrain(int Drain)
        {
            staminaDrain = Drain;
        }
        public void ChangeStamina(int NewStanima)
        {
            staminaDrain = NewStanima;
        }
        public void RemoveItem(int itemName)
        {
            if (itemsNeeded.ContainsKey(itemName))
            {
                itemsNeeded.Remove(itemName);
            }
            else
            {
                Debug.LogError("There is no item named :" + itemName);
            }
            #endregion
        }
    }
}
