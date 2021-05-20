using UnityEngine;

namespace TLY.Animation
{
    [RequireComponent(typeof(Animator))]
    public class EntityAnimator:MonoBehaviour
    {
        internal Animator _anima;
        public bool IsMoving { get; private set; }
        public int DirectionCheck { get => _anima.GetInteger("FacingDirection"); }
        //Action State


        private void Awake()
        {
            _anima = GetComponent<Animator>();
        }

        public void SetDirection(Vector2 Direction)
        {
            switch (Direction)
            {
                case Vector2 v when v.Equals(Vector2.up):
                    _anima.SetInteger("FacingDirection", 2);
                    break;
                case Vector2 v when v.Equals(Vector2.down):
                    _anima.SetInteger("FacingDirection", 0);
                    break;
                case Vector2 v when v.Equals(Vector2.right):
                    _anima.SetInteger("FacingDirection", 1);
                    break;
                case Vector2 v when v.Equals(Vector2.left):
                    _anima.SetInteger("FacingDirection", 3);
                    break;
            }
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
