using UnityEngine;
using System;
using System.Collections.Generic;

namespace TLY.ItemSystem
{
    public struct Recipe
    {
        private Dictionary<int, int> _ingredients;
        private int _output;
        private int _numOut;

        public Dictionary<int, int> ingredients => _ingredients;
        public int output => _output;
        public int numOut => _numOut;

        public void AddDictionaryEntry(int ItemID, int num) => _ingredients.Add(ItemID, num);
        public void RemoveDictionaryEntry(int ItemID) => _ingredients.Remove(ItemID);

    }
}
