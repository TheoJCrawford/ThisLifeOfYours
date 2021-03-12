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
        }
    }
}
