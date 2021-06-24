using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TLY.ItemSystem
{
    /// <summary>
    /// CraftingStationEditor acts as an overlay to the original CraftingStation script as the designer can not edit dictionaries without creating a script for it.
    /// <para>
    /// Due to the way inspectors work, dictionaries can not be displayed normally. The first lslider modifies the item that will be crafted.
    /// Second slider effects the item used to craft it.
    /// Third slider effects number of itmes needed.
    /// There will be a button that adds these items to the component side of the item.
    /// </para>
    /// </summary>
    [CustomEditor(typeof(CraftingStation))]
    public class CraftingStationEditor:Editor
    {
        #region variables
        private CraftingStation me;
        private ItemDatabase itemDb;

        private int itemID;
        private int ingredientID;
        private int numOfIngredient;
        private int reqNum;
        private Dictionary<int, int> Items;
        #endregion

        private void OnEnable()
        {
            me = (CraftingStation)target;
            itemDb = ItemDatabase.InstantiateItemDatabase();
            ResetItemEntry();
        }
        public override void OnInspectorGUI()
        {
            GUILayout.Label("Item Output: " + itemDb.ReturnItemName(itemID));
            itemID = EditorGUILayout.IntSlider(itemID, 0, itemDb.DbSize-1);
            GUILayout.Label("Ingredient: " + itemDb.ReturnItemName(ingredientID));
            ingredientID = EditorGUILayout.IntSlider(ingredientID, 0, itemDb.DbSize - 1);
            GUILayout.BeginHorizontal();
            GUILayout.Label("Number of: ", GUILayout.ExpandWidth(false));
            numOfIngredient = EditorGUILayout.IntSlider(numOfIngredient, 1, 10);
            GUILayout.EndHorizontal();
            

            if (GUILayout.Button("Add ingrident"))
            {
                AddIngredientToItem(ingredientID, numOfIngredient);
            }
            if (Items.Count > 0)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    GUILayout.BeginHorizontal();
                    GUILayout.Label(Items.Values.ElementAt(i).ToString() + "x " + itemDb.ReturnItemName(Items.Keys.ElementAt(i)));
                    if (GUILayout.Button("X"))
                    {
                        Items.Remove(Items.Keys.ElementAt(i));
                    }
                    GUILayout.EndHorizontal();
                }
            }
            
            if(GUILayout.Button("Add New Item")){
                
            }
        }
        private void ResetItemEntry()
        {
            itemID = 0;
            Items = new Dictionary<int, int>();
            ResetComponents();
        }

        private void ResetComponents()
        {
            ingredientID = 0;
            reqNum = 1;
        }
        private void AddIngredientToItem(int ItemID, int Ammount)
        {
            Items.Add(ItemID, Ammount);
            ResetComponents();
        }
    }
}
