using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLY.ItemSystem
{
    [System.Serializable]
    public class Armor:baseItem
    {
        private ArmorType _type;
        private int _armorVal;
        private int _speedVal;

        public int armourVal { get => _armorVal; }
        public int speedVal { get => _speedVal; }

        public Armor()
        {
            itemName = "Leather Armor";
            _type = ArmorType.Light;
            _armorVal = 5;
            _speedVal = 0;
        }

        public void ModifyArmourVal(int Modifier)
        {
            _armorVal = Modifier;
        }
        public void ModifySpeedVal(int Modifier)
        {
            _speedVal = Modifier;
        }
    }
    public enum ArmorType
    {
        Cloth,
        Light,
        Heavy
    };
}
