using UnityEngine;

namespace TLY.Animation
{
    public class EntityAnimator:MonoBehaviour
    {
        private Animator _anima;
        public bool IsMoving { get; private set; }
        public int DirectionCheck { get => _anima.GetInteger("FacingDirection"); }
        //Action State


        private void Awake()
        {
            _anima = GetComponent<Animator>();
        }

        public void SetDirection(int direction)
        {
            _anima.SetInteger("FacingDirection", direction);
        }
        public void BeginMovement()
        {
            if (!_anima.GetBool("IsMoving"))
            {
                _anima.SetBool("IsMoving", true);
            }
        }
        public void EndMovement()
        {
            if (_anima.GetBool("IsMoving"))
            {
                _anima.SetBool("IsMoving", false);
            }
        }
    }
}
