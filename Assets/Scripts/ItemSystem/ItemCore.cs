using UnityEngine;

[CreateAssetMenu(menuName ="TLY/Items/Base Item", fileName ="New Base Item.asset")]
public class ItemCore:ScriptableObject
{
    [SerializeField] private string _itemName;
    [SerializeField] private string _itemDesc;
    [SerializeField] private int _itemID;
    [SerializeField] private int _cost;
    [SerializeField] private ItemType _type;

    public string itemName => _itemName;
    public string itemDes => _itemDesc;
    public int itemID => _itemID;
    public virtual void UseItem()
    {

    }
    public virtual void DropItem()
    {

    }
    
    internal void ChangeItemType(ItemType newType)
    {
        _type = newType;
    }
}
public enum ItemType { Consumable, Equipment, Material }