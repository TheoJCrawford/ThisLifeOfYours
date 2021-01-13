using System.Collections.Generic;
using TLY.SkillSystem;
using UnityEngine;

namespace TLY.Core
{
    [CreateAssetMenu(fileName = "TempData", menuName = "TYL/Character/Temp Save Data")]
    public class PlayerTempData : ScriptableObject
    {
        [SerializeField] protected int _curHealth;
        [SerializeField] protected int _curStamina;

        [SerializeField] protected List<SkillBlock> skills;

        public List<SkillBlock> GetSkillBlock { get => skills; }
    }
}