using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace TLY.TownActivities.NPC
{
    [CustomEditor(typeof(BlacksmithTeacher))]
    public class BlacksmithTrainer:Editor
    {
        public override void OnInspectorGUI()
        {
            BlacksmithTeacher trainer = (BlacksmithTeacher)target;

            GUILayout.Label("Name: ");
            trainer.npcName = GUILayout.TextField(trainer.npcName);
            GUILayout.Label("State: ");
            trainer.curState = (NPCCore.NPCState)EditorGUILayout.EnumPopup("Curent State: ", trainer.curState);
            if(GUILayout.Button("Add Dialogue"))
            {
                trainer.dialoguelines.Add("What a wonderful line of text");
            }
            if(trainer.dialoguelines.Count > 0)
            {
                for(int i = 0; i < trainer.dialoguelines.Count; i++)
                {
                    GUILayout.BeginHorizontal();

                    trainer.dialoguelines[i] = GUILayout.TextField(trainer.dialoguelines.ElementAt(i));
                    if(GUILayout.Button("X", GUILayout.ExpandWidth(false)))
                    {
                        trainer.dialoguelines.RemoveAt(i);
                    }
                    GUILayout.EndHorizontal();
                }
            }
        }
    }
}
