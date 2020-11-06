using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace TLY.ItemSystem.Editor
{
    public class ItemDatabaseEditor : EditorWindow
    {
        public List<baseItem> _items;
        private baseItem _newItem;
        private GUIContent _sprite;

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
            if(GUILayout.Button("Add Item"))
            {
                _items.Add(_newItem);
                _newItem = new baseItem();
            }
            if(GUILayout.Button("Clear Item"))
            {
                _newItem = CreateInstance<baseItem>();
            }
            if(GUILayout.Button("Purge Items"))
            {
                _items = new List<baseItem>();
            }
            if(_items.Count > 0)
            {
                GUILayout.BeginHorizontal();
                for(int i = 0; i< _items.Count; i++)
                {
                    if (GUILayout.Button(_items.ElementAt(i).name))
                    {
                        index = i;
                        _newItem = _items.ElementAt(i);
                    }
                    if (GUILayout.Button("X", GUILayout.ExpandWidth(false)))
                    {
                        _items.RemoveAt(i);
                    }
                }
                GUILayout.EndHorizontal();
            }
            GUILayout.EndArea();
            #endregion
            #region Core Editor
            GUILayout.BeginArea(new Rect(200, 10, 400, 600));
            GUILayout.BeginHorizontal();
            GUILayout.Label("Name: ", GUILayout.ExpandWidth(false));
            _newItem.name = GUILayout.TextArea(_newItem.name);
            GUILayout.EndHorizontal();
            EditorGUILayout.Space();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Cost", GUILayout.ExpandWidth(false));
            EditorGUILayout.IntField(_newItem.coinValue);
            GUILayout.EndHorizontal();
            if(GUILayout.Button(_newItem.icon.texture,GUILayout.Height(100), GUILayout.Width(100)))
            {
                EditorGUIUtility.ShowObjectPicker<Sprite>(_newItem.icon,false, " ", 0);
            }
            if(Event.current.commandName == "ObjectSelectorUpdated")
            {
                _newItem.ChangeIcon((Sprite)EditorGUIUtility.GetObjectPickerObject());
            }
            GUILayout.EndArea();
            #endregion
        }
    }
}