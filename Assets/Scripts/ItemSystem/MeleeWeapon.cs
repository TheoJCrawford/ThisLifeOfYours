using UnityEngine;

namespace TLY.ItemSystem
{
    [CreateAssetMenu(fileName ="New Melee Weapon", menuName ="TLY/Items/New Melee Weapon")]
    public class MeleeWeapon:EquipableObject, iWeapon
    {
        public enum SkillDependant { Martial, Brawling, Thievery}
        
        [SerializeField]private int _damageVal;
        [SerializeField] private int _magicVal;
        [SerializeField] private float _attackSpeed;
        [SerializeField] private SkillDependant _skillReq;
        [SerializeField] private int _levelReq;
        
        public int damage => _damageVal;
        public int magic => _magicVal;
        public float attackSpeed => _attackSpeed;
        public SkillDependant skillRequired=> _skillReq;
        public int levelRequired => _levelReq;

        public MeleeWeapon()
        {
            SetEquipType(EquiableType.Hand);
        }
        
    }
}
