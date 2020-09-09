using UnityEditor;
using UnityEngine;


namespace TLY.Movement
{
    [CustomEditor(typeof(PlayerMovement))]
    public class PlayerMovementEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            GUILayout.BeginHorizontal();
            PlayerMovement player = (PlayerMovement)target;
            GUILayout.Label("Walk: ", GUILayout.ExpandWidth(false));
            player.moveSpeed = EditorGUILayout.Slider(player.moveSpeed, 1f, 50f);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Run: ", GUILayout.ExpandWidth(false));
            player.runSpeedl = EditorGUILayout.Slider(player.runSpeedl, 1f, 50f);
            GUILayout.EndHorizontal();
        }
    }
}