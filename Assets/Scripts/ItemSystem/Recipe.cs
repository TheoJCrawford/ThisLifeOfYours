using UnityEngine;
using System;
using System.Collections.Generic;

namespace TLY.ItemSystem
{
    [Serializable]
    public struct Recipe
    {
        [SerializeField] private Dictionary<int, int> _ingredients;
        [SerializeField] private int _output;
        [SerializeField] private int _numOut;
        [SerializeField] private int _recDif;
        [SerializeField] private int _skilRlLvl;

        public int refDif => _recDif;
        public Dictionary<int, int> ingredients => _ingredients;
        public int output => _output;
        public int numOut => _numOut;
        public int skillLvl => _skilRlLvl;

        public void SetRefDif(int Difficulty) => _recDif = Difficulty;
        public void AddDictionaryEntry(int ItemID, int num) => _ingredients.Add(ItemID, num);
        public void RemoveDictionaryEntry(int ItemID) => _ingredients.Remove(ItemID);
        public void SetSkill( int SkillRank)=> _skilRlLvl = SkillRank; 

        public Recipe(int item = 0, int num = 1, int output = 6, int outVal = 2, int dif = 1, int SRL = 1)
        {
            _ingredients = new Dictionary<int, int>();
            _ingredients.Add(item, num);
            _output = output;
            _numOut = outVal;
            _recDif = dif;
            _skilRlLvl = SRL;
        }
    }
}
