using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace TLY.ItemSystem.Editor
{
    public class ItemDatabaseEditor : EditorWindow
    {
        private ItemDatabase itemDatabase;

        private string _itemName;
        private string _itemDescript;
        private int _itemCost;
        private Sprite _sprite;

        private int damageVal;
        private float _ar;
        private MeleeWeaponTypes MeleeWeaponType;
        private RangedWeaponType RangedWeaponTyp;
       
        private enum ItemConstructing { none, baseItem, mWeapon, rWeapon, Armor, Consumable};
        private ItemConstructing ItemCon;

        private int index = -1;

        [MenuItem("TLFY/Item Database")]
        private static void OnEnable()
        {
            ItemDatabaseEditor window = (ItemDatabaseEditor)EditorWindow.GetWindow<ItemDatabaseEditor>();
            window.minSize = new Vector2(600, 600);
            window.maxSize = new Vector2(600, 600);
            window.Show();
            
        }
        
        private void OnDisable()
        {
            
        }
        private void OnGUI()
        {
            
            #region SideBar
            GUILayout.BeginArea(new Rect(10,10,180,600));
            if(GUILayout.Button("New Item"))
            {
                ItemCon = ItemConstructing.baseItem;
            }
            if (GUILayout.Button("New Melee Weapon"))
            {
                ItemCon = ItemConstructing.mWeapon;
            }
            if(GUILayout.Button("New Ranged Weapon"))
            {
                ItemCon = ItemConstructing.rWeapon;
            }
            if(GUILayout.Button("New Armor"))
            {
                ItemCon = ItemConstructing.Armor;
            }
            if (GUILayout.Button("Save New Item"))
            {

            }
            if (GUILayout.Button("Clear Item"))
            {
                
            }
            if(GUILayout.Button("Purge Items"))
            {
                
            }
            
            GUILayout.EndArea();
            #endregion
            #region Main Editor
            switch (ItemCon)
            {
                case ItemConstructing.baseItem:
                    break;
                case ItemConstructing.mWeapon:
                    break;
                case ItemConstructing.rWeapon:
                    break;
                case ItemConstructing.Armor:
                    break;
                default:
                    break;
            }
            #endregion
        }

    }
}