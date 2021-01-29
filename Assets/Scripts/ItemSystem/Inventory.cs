using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TLY.ItemSystem
{
    public class Inventory
    {
        private const int BASE_SIZE = 20;

        private List<ItemCore> _items;
        private int _curIvenSize;

        public int InventSize => _curIvenSize;
        public Inventory()
        {
            _items = new List<ItemCore>();
            _curIvenSize = BASE_SIZE;
        }
        public void UpdateIvenSize(int sizeIncrease)
        {
            if( _curIvenSize + sizeIncrease  >= BASE_SIZE)
            {
                _curIvenSize += sizeIncrease;
            }
            else
            {
                _curIvenSize = BASE_SIZE;
            }
        }
        public void AddItem(ItemCore newItem) { 
            if(_items.Count() > _curIvenSize)
            {
                _items.Add(newItem);
            }
            else
            {
                Debug.Log("Nope");
            }
        }
        public void RemoveItem(ItemCore RemovedItem, int numRemoved = 1)
        {
            if (_items.Contains(RemovedItem)  && _items.Count(x => x == RemovedItem) >= numRemoved)
            {
                foreach(ItemCore item in _items)
                {
                    if(item == RemovedItem)
                    {
                        _items.Remove(item);
                    }
                }
            }
        }
    }
}
