using System.Collections.Generic;
using System.Linq;
public class Inventory
{
    private const int BASE_INVENTORY = 15;
    private int _bonusInventSize;
    private List<int> _invent;

    public int InventSize => BASE_INVENTORY + _bonusInventSize > 0? BASE_INVENTORY + _bonusInventSize:1;
    public bool IsFull => _invent.Count == InventSize;
    public int NumOfItem(int ItemID = 0) => _invent.Contains(ItemID) ? _invent.Count(i => i == ItemID) : 0;

    public Inventory()
    {
        _bonusInventSize = 0;
        _invent = new List<int>();
    }

    public void AddNewItem(int ItemID = 0, int ItemNum = 1) //Default is wood and adds one of it
    {
        if(!IsFull && InventSize + ItemNum <= InventSize && ItemNum > 0)
        {
            do
            {
                _invent.Add(ItemID);
                ItemNum--;
            } while (ItemNum > 0);
        }
    }
    public void RemoveItem(int ItemID = 0, int ItemNum = 1)
    {
        do
        {
            _invent.Remove(ItemID);
            ItemNum--;
        } while (ItemNum > 0);
    }
    
}
