using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace TLY.ItemSystem
{
    [CustomEditor(typeof(ItemCore))]
    public class ItemCoreEditor : Editor
    {
        private SuperItemType ItemType;
        ItemCore item;
        
        public override void OnInspectorGUI()
        {
            
            GUILayout.Label("Name: ");
            item.ChangeName(GUILayout.TextField(item.itemName));
            GUILayout.Label("Cost: ");
            item.SetCost(EditorGUILayout.IntSlider(item.cost, 1, 9999));
            GUILayout.Label("Icon sprite: ");
            if(GUILayout.Button("Select Sprite")){
                EditorGUIUtility.ShowObjectPicker<Sprite>(null, false, "", 0);
            }
        }
        
    }    
}