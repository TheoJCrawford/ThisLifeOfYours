
namespace TLY.ItemSystem
{
    [System.Serializable]
    public class RangedWeapon : baseItem, iWeapon
    {
        private int _damage;
        private float _roa;
        private RangedWeaponType _type;
        public int Damage => _damage;
        public float RateOfAttack => _roa;
        public RangedWeaponType Type => _type;

        public void SetDamage(int Damage)
        {
            _damage = Damage;
        }
    }
    public enum RangedWeaponType
    {
        Short_Bow,
        Crossbow
    }
}
