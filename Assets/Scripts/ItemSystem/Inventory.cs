using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace TLY.ItemSystem
{
    public class Inventory
    {
        private int MAX_SIZE = 20;
        public List<baseItem> invent { get; internal set; }

        public Inventory()
        {
            invent = new List<baseItem>();
            
        }
        public Inventory(int size)
        {
            invent = new List<baseItem>();
            MAX_SIZE = size;
        }

        public int GetNumItemType(string Name)
        {

            return invent.Count(s => s.itemName == @Name);
        }
        public void AddItem(baseItem Item)
        {
            if(invent.Count < MAX_SIZE)
            {
                invent.Add(Item);
            }
        }
        public void RemoveItem(string Name)
        {
            for(int i = 0; i < invent.Count; i++)
            {
                if(invent[i].itemName == @Name)
                {
                    invent[i] = null;
                    break;
                }
            }
        }
        public void RemoveItem(int Point)
        {
            invent[Point] = null;
        }

        public bool CheckEnough(string Name, int Num)
        {
            int check = 0;
            foreach (baseItem item in invent)
            {
                if (item.itemName == Name)
                {
                    check++;
                }
            }
            return check >= Num ? true : false;
        }

        public void IncreaseInventorySize(int increase)
        {
            MAX_SIZE += increase;
        }
        public void RemoveItem(string Name, int Num)
        {
            if(Num <= 0)
            {
                Debug.Log("Can't add when you are supposed to be doing the opposite");
                return;
            }
            do
            {
                invent.Remove(invent.First(x => x.itemName == @Name));
                Num--;
            } while (Num > 0);
        }
    }
}