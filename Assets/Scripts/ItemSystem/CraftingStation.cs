using System.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace TLY.ItemSystem {
    [Serializable]
    public class CraftingStation : MonoBehaviour
    {
        [SerializeField] private List<Recipe> recipes;

        public Recipe ReturnRecipe(int RecipeNum) => recipes.ElementAt(RecipeNum);
        public void AddNewRecipe(int ItemID, int ItemOutput, int SkillLevel, int Difficulty, Dictionary<int,int> Ingredients)
        {
            recipes.Add(new Recipe(SkillLevel, Difficulty, ItemID, ItemOutput, Ingredients));
        }
    }
}