using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TLY.ItemSystem
{
    [RequireComponent(typeof(ChestAnimator))]
    public class Chest : MonoBehaviour
    {
        private bool _chestState = false;
        ChestAnimator _chest;
        private void Awake()
        {
            _chest = GetComponent<ChestAnimator>();
        }
        public virtual void OpenChest()
        {
            _chestState = true;
            _chest.OpenChest();
        }
        public virtual void CloseChest()
        {
            _chestState = false;
            _chest.CloseChest();
        }
    }
}
