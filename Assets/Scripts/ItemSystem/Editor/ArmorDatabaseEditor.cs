using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;

namespace TLY.ItemSystem.Editor {
    public class ArmorDatabaseEditor : EditorWindow
    {
        [MenuItem("TLFY/Armour Database")]
        private static void OnEnable()
        {
            ArmorDatabaseEditor window = (ArmorDatabaseEditor)EditorWindow.GetWindow(typeof(ArmorDatabaseEditor));
            window.minSize = new Vector2(600, 600);
            window.maxSize = new Vector2(600, 600);
            window.Show();
        }

        private void OnGUI()
        {
            #region
            GUILayout.BeginArea(new Rect(1, 1, 150, 599));
            GUILayout.Button("New Armour");
            GUILayout.Button("Save Armour");
            GUILayout.Button("Clear Slection");
            GUILayout.EndArea();
            #endregion
            #region
            GUILayout.BeginArea(new Rect(151,1,450, 599));
            GUILayout.Label("Name:");
            GUILayout.Label("Cost: ");
            GUILayout.Label("Armour Value");
            GUILayout.Label("Sprite: ");
            GUILayout.EndArea();
            #endregion
        }
    }
}