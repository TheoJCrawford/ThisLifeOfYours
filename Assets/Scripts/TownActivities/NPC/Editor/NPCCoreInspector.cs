using UnityEditor;
using UnityEngine;
using System;

namespace TLY.TownActivities.NPC
{
    [CustomEditor(typeof(NPCCore))]
    public class NPCCoreInspector : Editor
    {
        private string[] _genderOption = {"Male","Female", "Unknown"};
        private int _genderSelector;
        public override void OnInspectorGUI()
        {
            
            NPCCore npc = (NPCCore)target;
            _genderSelector = Array.IndexOf(_genderOption, npc.gender);
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Name: ",GUILayout.ExpandWidth(false));
            npc.npcName = GUILayout.TextField(npc.npcName);
            GUILayout.EndHorizontal();
            GUILayout.Label("Intro Line: ");
            npc.IntroductionLine = GUILayout.TextArea(npc.IntroductionLine);
            GUILayout.Label("Gender: " + npc.gender);
            npc.ChangeGender(EditorGUILayout.Popup(_genderSelector, _genderOption));
        }
    }
}