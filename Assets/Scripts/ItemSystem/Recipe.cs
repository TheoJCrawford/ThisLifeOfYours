using UnityEngine;
using System;
using System.Collections.Generic;

namespace TLY.ItemSystem
{
    /// <summary>
    /// This structure is designed to hold information regarding crafting recipies.
    /// <para>
    /// _igredient dictionary holds the ItemID as the key and the number of items needed as the value.
    /// _ouput houses itemID for outputed item
    /// _numOut is houses how many of an item will be returned upon crafting success
    /// _skillRlvl is the required level the crafting skill needs to be.
    /// </para>
    /// </summary>
    [Serializable]
    public struct Recipe
    {
        private Dictionary<int, int> _ingredients;
        private int _output;
        private int _numOut;
        private int _recDif;
        private int _skilRlLvl;
        #region Requesers
        public int refDif => _recDif;
        public Dictionary<int, int> ingredients => _ingredients;
        public int output => _output;
        public int numOut => _numOut;
        public int skillLvl => _skilRlLvl;
        #endregion
        public Recipe(int SkillRaiting, int Difficulty, int Ouput,int OutNum, Dictionary<int, int> Ingredients)
        {
            _ingredients = new Dictionary<int, int>();
            _ingredients = Ingredients;
            _output = Ouput;
            _numOut = OutNum;
            _recDif = Difficulty;
            _skilRlLvl = SkillRaiting;
        }
    }
}
