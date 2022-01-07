using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TLY.ItemSystem
{
    [Serializable]
    public class TreasureChest:Chest
    {
        [SerializeField] private Dictionary<int, int> _rewards;
        [SerializeField] private bool _isOpened;
        public Dictionary<int, int> rewards => _rewards;
        public bool isOpened => _isOpened;

        public void AddNewReward(int id, int num)
        {
            _rewards.Add(id, num);
        }
        public void RemoveReward(int id)
        {
            _rewards.Remove(id);
        }
    }
}
