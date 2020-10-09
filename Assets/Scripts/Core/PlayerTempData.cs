using Boo.Lang;
using TLY.ItemSystem;
using TLY.SkillSystem;
using UnityEngine;

namespace TLY.Core
{
    [CreateAssetMenu(fileName = "TempData", menuName = "TYL/Character/Temp Save Data")]
    public class PlayerTempData : ScriptableObject
    {
        [SerializeField] protected int _curHealth;
        [SerializeField] protected int _curStamina;
        [SerializeField] protected Inventory inventory;
        [SerializeField] protected List<SkillBlock> skills;

        public Inventory GetInven { get => inventory; }
        public List<SkillBlock> GetSkillBlock { get => skills; }
    }
}