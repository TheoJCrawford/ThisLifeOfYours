using System.Linq;
using System.Reflection.Emit;
using UnityEditor;
using UnityEngine;

namespace TLY.Animation
{
    [CustomEditor(typeof(PlayerAnimator))]
    public class PlayerAnimatorEditor : Editor
    {
        string[] directions = { "South", "East", "North", "West" };
        public override void OnInspectorGUI()
        {
            PlayerAnimator anima = (PlayerAnimator)target;
            GUILayout.Label("Direction faced: " + directions.ElementAt(anima.DirectionCheck));
        }
    }
}