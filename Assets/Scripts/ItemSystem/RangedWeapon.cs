using UnityEngine;

namespace TLY.ItemSystem
{
    [CreateAssetMenu(menuName ="TLY/Items/New Ranged Weapon")]
    public class RangedWeapon : EquipableObject, iWeapon
    {
        public enum SkillDependant { Thaumatergy, Tinker, Martial };

        [SerializeField] private int _damage;
        [SerializeField] private float _attackSpeed;
        [SerializeField] private SkillDependant skillReq;
        [SerializeField] private int levelReq;
        

        public RangedWeapon()
        {
            SetEquipType(EquiableType.Hand);
        }

        public int damage => _damage;
        public float attackSpeed => _attackSpeed;
    }
}
