using System;
using UnityEngine;
using UnityEditor;



public class ItemDatatableEditor : EditorWindow
{
    ItemDatabase dB;

    private int _indexer = -1;

    string itemName;
    int itemCost;
    string itemDescrip;
    string itemIcon;
    Vector2 scrollPos;
    
    GUIContent content = new GUIContent();
    ItemType iType = ItemType.Material;

    [MenuItem("TLOY/Item DB Editor")]
    public static void ShowWindow()
    {
        EditorWindow window = GetWindow(typeof(ItemDatatableEditor));
        window.minSize = new Vector2(600, 500);
        window.name = "Item Editor";
    }
    private void OnEnable()
    {

        dB = ItemDatabase.InstantiateItemDatabase();
        RefreshItem();
    }
    
    private void OnGUI()
    {
        SideBar();
        MainBar();
    }
    private void SideBar()
    {
        GUILayout.BeginArea(new Rect(0, 0, 150, 550));
        if(GUILayout.Button("Reset Item"))
        {
            RefreshItem();
        }
        if (GUILayout.Button("Save Database"))
        {
            dB.SaveDataTable();
        }
        if (dB.DbSize > 0)
        {
            scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
            for (int i = 0; i < dB.DbSize; i++)
            {
                if(GUILayout.Button(i.ToString() + " " + dB.ReturnItemName(i)))
                {
                    _indexer = i;
                    itemName = dB.ReturnItemName(i);
                    itemCost = dB.ReturnItemCost(i);
                    itemDescrip = dB.ReturnItemDecsript(i);
                    itemIcon = dB.ReturnItemSpPath(i);
                    content.image = (Texture)AssetDatabase.LoadAssetAtPath(dB.ReturnItemSpPath(i), typeof(Texture));
                    iType = dB.ReturnItemType(i);
                }
            }
            EditorGUILayout.EndScrollView();
        }
        GUILayout.EndArea();
    }
    private void MainBar()
    {
        #region Item Data Entry
        GUILayout.BeginArea(new Rect(150, 0, 350, 550));
        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal();
        GUILayout.Label("Item Name:", GUILayout.ExpandWidth(false));
        itemName = GUILayout.TextField(itemName);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Item Cost", GUILayout.ExpandWidth(false));
        itemCost = EditorGUILayout.IntSlider(itemCost, 0, 999);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Item Description", GUILayout.ExpandWidth(false));
        itemDescrip = EditorGUILayout.TextArea(itemDescrip);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        
        GUILayout.Label("Item Icon", GUILayout.ExpandWidth(false));
        GUILayout.Label(itemIcon);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Item Type");
        iType = (ItemType)EditorGUILayout.EnumPopup(iType);
        GUILayout.EndHorizontal();
        if (GUILayout.Button(content, GUILayout.Width(50f), GUILayout.Height(50f)))
        {
            EditorGUIUtility.ShowObjectPicker<Texture>(content.image, false, "", 0);
        }
        if (Event.current.commandName == "ObjectSelectorUpdated")
        {
            content.image = (Texture)EditorGUIUtility.GetObjectPickerObject();
            itemIcon = AssetDatabase.GetAssetPath(content.image);
            itemIcon = itemIcon.Replace("Assets/Resources/", "");
        }
#endregion
        if (GUILayout.Button("Save Item") && itemName != " ")
        {
            if(_indexer == -1)
            {
                dB.AddNewItem(itemName, itemCost, itemDescrip, itemIcon, iType);
                RefreshItem();
            }
            else
            {
                dB.EditItem(_indexer, itemName, itemCost, itemDescrip, itemIcon, iType);
                RefreshItem();
            }
            
        }
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
    void RefreshItem()
    {
        _indexer = -1;
        itemName = " ";
        itemCost = 0;
        itemDescrip = "A red fruit that falls from trees.";
        content = new GUIContent();
        itemIcon =  "Asset/Art/Sprites/Apple.png";
        iType = ItemType.Material;
    }
}
