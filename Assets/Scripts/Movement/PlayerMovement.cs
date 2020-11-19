using System;
using UnityEngine;

namespace TLY.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] public float moveSpeed = 2f;
        [SerializeField] public float runSpeed = 5f;

        private Vector2 _moveDirection;
        private Vector2 _lookPos;
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
            AddModifiers();
            EnactMovement();
        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.name != null){
                Debug.Log("Ping");
            }
            

        }
        private void EnactMovement()
        {
            _self.velocity = _moveDirection;   
        }
        public void TakeInput(float Up, float Right)
        {
            _moveDirection = Vector2.zero;
            _moveDirection = new Vector2(Up, Right);
            _lookPos = new Vector2(Up, Right);
        }
        private void AddModifiers()
        {
            if(_moveDirection.magnitude > 1)
            {
                _moveDirection.Normalize();
            }

            if (_isSprinting)
            {
                _moveDirection *= runSpeed;
            }
            else
            {
                _moveDirection *= moveSpeed;
            }
        }

        internal void sprintState(bool v)
        {
            _isSprinting = v;
        }
    }
}