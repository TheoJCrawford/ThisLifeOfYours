using UnityEditor;
using UnityEngine;
using System.Linq;

namespace TLY.Animation
{
    [CustomEditor(typeof(NPCAnimator))]
    public class NPCAnimatorEditor:Editor
    {
        string[] directions = { "South", "East", "North", "West" };
        public override void OnInspectorGUI()
        {
            NPCAnimator anima = (NPCAnimator)target;
            if (Application.isPlaying)
            {
                GUILayout.Label("Direction faced: " + directions.ElementAt(anima.DirectionCheck));
            }
        }
    }
}
