using System;
using UnityEngine;

namespace TLY.Animation
{
    [RequireComponent(typeof(Animator))]
    public class PlayerAnimator : EntityAnimator
    {

       internal void SetSpritState(bool v)
        {
            _anima.SetBool("isSprinting", v);
        }
    }
}