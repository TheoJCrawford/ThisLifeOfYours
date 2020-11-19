

namespace TLY.ItemSystem
{
    [System.Serializable]
    public class MeleeWeapon :baseItem, iWeapon
    {
        private int _damage;
        private float _roa;
        private MeleeWeaponTypes _types;

        public int Damage => _damage;
        public float RateOfAttack => _roa;
        public MeleeWeaponTypes types => _types;

        public MeleeWeapon()
        {
            _damage = 5;
        }
    }
    public enum MeleeWeaponTypes
    {
        Wraps,
        Shortsword,
        Longsword,
        Greatsword,
        Spear,
        Axe,
    }
}
