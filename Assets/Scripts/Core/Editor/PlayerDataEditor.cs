using NUnit.Framework.Internal.Builders;
using System.Reflection.Emit;
using UnityEditor;
using UnityEngine;
using TLY.SkillSystem;
using UnityEngine.PlayerLoop;
using System.Linq;

namespace TLY.Core
{
    [CustomEditor(typeof(PlayerData))]
    public class PlayerDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {

            PlayerData player = (PlayerData)target;
            #region Save Button
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Find Save Data", GUILayout.ExpandWidth(false)))
            {
                EditorGUIUtility.ShowObjectPicker<SaveData>(player.save, false, "", 0);


            }
            if (Event.current.commandName == "ObjectSelectorUpdated")
            {
                player.save = (SaveData)EditorGUIUtility.GetObjectPickerObject();
                Debug.Log("Save data linked");
                player.charName = player.save.charName;
            }
            if (GUILayout.Button("X", GUILayout.ExpandWidth(false)))
            {
                player.save = null;
                Debug.Log("There is no save data anymore");
            }
            GUILayout.EndHorizontal();
            #endregion
            #region If there is no save data
            if (player.save == null)
            {
                GUILayout.Label("There is no save data");
                GUILayout.Label("Name: ");
                player.charName = GUILayout.TextField(player.charName);
                player.gender = (Gender)EditorGUILayout.EnumPopup(player.gender);
                if(player.Skills.Count> 0 || player.Skills == null)
                {
                    for(int i = 0; i > player.Skills.Count; i++)
                    {
                        GUILayout.BeginHorizontal();
                        GUILayout.Label(player.Skills.ElementAt(i).name);
                        GUILayout.Label(player.Skills.ElementAt(i).level.ToString());
                    }
                }
            }
            #endregion
            #region If there is save data
            else
            {
                GUILayout.Label("This is the save data for " + player.save.charName);
                GUILayout.Label("Name: ");
                player.save.ChangeName(GUILayout.TextField(player.save.charName));
                player.save.gender = (Gender)EditorGUILayout.EnumPopup(player.save.gender);
                if(player.save.Skills.Count > 0)
                {
                    for(int i = 0; i <player.save.Skills.Count; i++)
                    {
                        GUILayout.Label(player.save.Skills[i].name);
                    }
                }
                if(player.save.Invent.invent.Count > 0)
                {
                    for(int i = 0; i< player.save.Invent.invent.Count; i++)
                    {
                        GUILayout.BeginHorizontal();
                        GUILayout.Label(player.save.Invent.invent.ElementAt(i).name);
                        GUILayout.Button("X", GUILayout.ExpandWidth(false));
                    }
                }
               
            }
            #endregion
        }
    }
}
