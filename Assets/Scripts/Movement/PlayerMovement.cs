using System;
using UnityEngine;

namespace TLY.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] public float moveSpeed = 2f;
        [SerializeField] public float runSpeed = 5f;

        protected static Vector2 _inputDirection;
        private static Vector2 _moveDirection;

        private Rigidbody2D _self;
        private bool _isSprinting;
        // Start is called before the first frame update
        void Start()
        {
            _self = GetComponent<Rigidbody2D>();
            if (_self.gravityScale > 0f)
            {
                _self.gravityScale = 0f;
            }
            _isSprinting = false;
        }
        // Update is called once per frame
        void LateUpdate()
        {
            ConvertToMove();
            AddSpeedModifiers();
            AddFixedDelta();
            EnactMovement();
        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.name != null){
                Debug.Log("Ping");
            }
            

        }
        
        private void EnactMovement() => _self.MovePosition(_self.position+_moveDirection);   
        public void TakeInput(Vector2 MoveVec)=> _inputDirection = MoveVec;
        internal void ConvertToMove() => _moveDirection = _inputDirection;
        private void AddSpeedModifiers()
        {
            NormalizationCheck();

            if (_isSprinting)
            {
                _moveDirection *= runSpeed;
            }
            else
            {
                _moveDirection *= moveSpeed;
            }
        }
        private void AddFixedDelta() => _moveDirection *= Time.fixedDeltaTime;
        private static void NormalizationCheck()
        {
            if (_moveDirection.magnitude > 1)
            {
                _moveDirection.Normalize();
            }
        }

        internal void sprintState(bool v)
        {
            _isSprinting = v;
        }
    }
}