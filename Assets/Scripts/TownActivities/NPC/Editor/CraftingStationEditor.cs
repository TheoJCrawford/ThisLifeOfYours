using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

namespace TLY.ItemSystem
{
    [CustomEditor(typeof(CraftingStation))]
    public class CraftingStationEditor:Editor
    {
        CraftingStation me;
        ItemDatabase items;
        int itemNum;
        Dictionary<int, int> Items;

        
        private void OnEnable()
        {
            me = (CraftingStation)target;
            items = ItemDatabase.InstantiateItemDatabase();
            

        }
        public override void OnInspectorGUI()
        {
            GUILayout.Label("Item Output: " + items.ReturnItemName(itemNum));
            itemNum = EditorGUILayout.IntSlider(itemNum, 0, items.DbSize-1);
            if(Items.Count > 0)
            {
                
            }
            if(GUILayout.Button("Add New Item")){

            }
        }
        private void ResetItemEntry()
        {
            itemNum = 0;
        }
    }
}
