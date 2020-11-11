using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TLY.ItemSystem
{
    public class Workspace:MonoBehaviour
    {
        public string Title;
        public CraftingClass stationType;       

        [SerializeField] private List<Recipe> _recipes;
    }
    public enum CraftingClass
    {
        Thaumatergy,
        Smithing,
        Leathcraft,
        Tailor,
        Alchemy
    };
}
