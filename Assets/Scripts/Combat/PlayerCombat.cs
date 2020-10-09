

using TLY.Core;
using UnityEngine;

namespace TLY.Combat
{
    public class PlayerCombat:MonoBehaviour
    {
        private PlayerData _data;

        private void Awake()
        {
            _data = GetComponent<PlayerData>();
        }
        public void Attack()
        {
            /*
             * So, character will swping (check animation)
             * If the target takes a hit, get the target's Take Hit function
             */
        }
        public void TakeHit(int damageIncoming)
        {
            
        }
    }
}
