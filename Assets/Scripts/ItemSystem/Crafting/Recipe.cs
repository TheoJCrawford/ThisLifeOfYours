using System.Collections.Generic;
using UnityEngine;

namespace TLY.ItemSystem
{
    public struct Recipe
    {
        [SerializeField] public int levelReq { get; internal set; }
        [SerializeField] public int staminaDrain { get; internal set; }
        [SerializeField] public Dictionary<string, int> itemsNeeded { get; set; }
        [SerializeField] public int returningNumber;
        [SerializeField] public baseItem _output;

        public bool _canbeHQ;

        public Recipe(int LvlRq, string Component, int Req, baseItem Output, int Returning, bool HQ)
        {
            levelReq = LvlRq;
            itemsNeeded = new Dictionary<string, int>();
            itemsNeeded.Add(Component, Req);
            _output = Output;
            returningNumber = Returning;
            _canbeHQ = HQ;
            staminaDrain = 1;
        }

        #region Editor
        public void AddToItemsNeeded(string itemName, int value)
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
        public void RemoveItem(string itemName)
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
