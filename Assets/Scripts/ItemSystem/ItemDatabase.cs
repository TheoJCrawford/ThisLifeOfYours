using System;
using System.IO;
using System.Data;
using UnityEngine;


public class ItemDatabase
{
    DataSet itemDeus;
    DataTable itemDb;
    //DataTable weaponDb;


    public int DbSize => itemDb.Rows.Count;
    #region Core DB Returns
    public string ReturnItemName(int index) => itemDb.Rows.Find(index)["Item Name"].ToString();
    public Texture ReturnItemSprite(int index) => Resources.Load<Texture>(itemDb.Rows.Find(index)["Sprite Address"].ToString());
    public string ReturnItemSpPath(int index) => itemDb.Rows.Find(index)["Sprite Address"].ToString();
    public int ReturnItemCost(int index) => Convert.ToInt32(itemDb.Rows[index]["Cost"]);
    public string ReturnItemDecsript(int index) => itemDb.Rows.Find(index)["Item Desription"].ToString();
    public ItemType ReturnItemType(int index) => (ItemType)itemDb.Rows.Find(index)["Item type"];
    #endregion
    public void CreateDatatable()
    {
        var primaryKeys = new DataColumn[1];
        itemDeus = new DataSet();
       // weaponDb = new DataTable();
        itemDb = new DataTable();

# region Item ID column
        DataColumn dataColumn = new DataColumn();
        dataColumn.ColumnName = "ID";        
        dataColumn.DataType = typeof(int);
        dataColumn.AutoIncrement = true;
        dataColumn.AutoIncrementSeed = 0;
        dataColumn.AutoIncrementStep = 1;
        dataColumn.ReadOnly = true;
        primaryKeys[0] = dataColumn;
        itemDb.Columns.Add(dataColumn);
        #endregion
# region Item Name
        DataColumn dataColumn1 = new DataColumn();
        dataColumn1.ColumnName = "Item Name";
        dataColumn1.DataType = typeof(string);
        itemDb.Columns.Add(dataColumn1);
        #endregion
#region Item Cost
        DataColumn dataColumn2 = new DataColumn();
        dataColumn2.ColumnName = "Cost";
        dataColumn2.DataType = typeof(int);
        itemDb.Columns.Add(dataColumn2);
        #endregion
#region Item Sprite
        DataColumn dataColumn3 = new DataColumn();
        dataColumn3.ColumnName = "Sprite Address";
        dataColumn3.Unique = true;
        dataColumn3.DataType = typeof(string);
        itemDb.Columns.Add(dataColumn3);
        #endregion
#region Item Type
        DataColumn dataColumn4 = new DataColumn();
        dataColumn4.ColumnName = "Item type";
        dataColumn4.DataType = typeof(ItemType);
        itemDb.Columns.Add(dataColumn4);
        #endregion
# region Item Descriptor
        DataColumn dataColumn5 = new DataColumn();
        dataColumn5.ColumnName = "Item Desription";
        dataColumn5.DataType = typeof(string);
        itemDb.Columns.Add(dataColumn5);
        #endregion
        itemDb.PrimaryKey = primaryKeys;
        itemDeus.Tables.Add(itemDb);
    }


    public void PopulateDatatable()
    {
        if (File.Exists("Assets/Database/ItemDB.xml"))
        {
            using (StreamReader reader = new StreamReader("Assets/Database/ItemDB.xml"))
            {
                itemDb.ReadXml(reader);
            }
        }
    }

    public  void SaveDataTable()
    {
        using (StreamWriter writer = new StreamWriter("Assets/Database/ItemDB.xml"))
        {
            itemDb.WriteXml(writer);
        }
    }

    public void AddNewItem(string Name = "Iron Ore", int ItemCost = 5, string ItemDescript = "A climp of iron found in mines. \n Used in making iron and steel.", string SpriteString = "Assets/Art/itemIcons/IronOre.png", ItemType ItemType = ItemType.Material)
    {
        DataRow dataRow = itemDb.NewRow();
        dataRow["Item Name"] = Name;
        dataRow["Cost"] = ItemCost;
        dataRow["Sprite Address"] = SpriteString;
        dataRow["Item type"] = ItemType;
        dataRow["Item Desription"] = ItemDescript;
        itemDb.Rows.Add(dataRow);

    }

    public  void EditItem(int index, string Name, int ItemCost, string ItemDescript, string SpriteString, ItemType IType)
    {
        DataRow row = itemDb.Rows.Find(index);
        
        row["Cost"] = Name;
        row["Cost"] = ItemCost;        
         row["Sprite Address"] = SpriteString;
        row["Item type"] = IType;
        row["Item Description"] = ItemDescript;
    }
}
public enum ItemType
{
    Material,
    Consumeable,
    Weapon,
    Armor
};