using UnityEngine;

namespace TLY.ItemSystem
{
    [CreateAssetMenu(fileName ="New Melee Weapon", menuName ="TLY/Items/New Melee Weapon")]
    public class MeleeWeapon:EquipableObject, iWeapon
    {
        public enum SkillDependant { Martial, Brawling, Thievery}
        
        [SerializeField]private int damageVal;
        [SerializeField] private float _attackSpeed;
        [SerializeField] private SkillDependant skillReq;
        [SerializeField] private int levelReq;

        public MeleeWeapon()
        {
            SetEquipType(EquiableType.Hand);
        }
        public int damage => damageVal;
        public float attackSpeed => _attackSpeed;
    }
}
