using NUnit.Framework.Internal.Builders;
using System.Reflection.Emit;
using UnityEditor;
using UnityEngine;

namespace TLY.Core
{
    [CustomEditor(typeof(PlayerData))]
    public class PlayerDataEditor:Editor
    {
        private string _saveStatus;
        
        public override void OnInspectorGUI()
        {
            PlayerData player = (PlayerData)target;
            



            GUILayout.Label("Name: ");
            player.charName = GUILayout.TextField(player.charName);
            

            GUILayout.Label("Save Data: " + player.save.name);
            if(GUILayout.Button("Get Save Data"))
            {
                EditorGUIUtility.ShowObjectPicker<SaveData>(player.save,false,"",0);
            }
        }
    }
}
