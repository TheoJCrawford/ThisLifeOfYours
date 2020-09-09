using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TLY.Combat
{
    public class PlayerCombat:MonoBehaviour
    {
        PlayerData _data;
        
        public void Attack()
        {
            /*
             * So, character will swping (check animation)
             * If the target takes a hit, get the target's Take Hit function
             */
        }
        public void TakeHit(int damageIncoming)
        {
            if(damageIncoming > 0)
            {
                _data.ModifyCurHealth(-damageIncoming);
            }
            else if( damageIncoming == 0)
            {

            }
            else
            {

            }
        }
    }
}
