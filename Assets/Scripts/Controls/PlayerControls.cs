using UnityEngine;
using TLY.Movement;
using TLY.Animation;
using UnityEngine.InputSystem;
using System;

namespace TLY.Controls
{
    /// <summary>
    /// This script handles the controls and their attachment to certain scripts
    /// <para>
    /// When the script is attached to an object, the PlayerMovement, PlayerAnimator, and PlayerInput scripts are added to the GameObject. See RequireComponent Unity Documentation
    /// Start creates reference points for the PlayerMover, PlayerAnimator, and PlayerInput and sts up the InputActions for Move, run, and interact.
    /// </para>
    /// <para>
    /// TakeMoveInput takes the moveInput set in _moveAction and applies it to the Mover and Animator functions. Furthermore, should the moveInput's magnitude be greater then 0, it turns the animation for walking on, and off when it is equal to 0.
    /// TakeSprintInput takse whether the button is down or not, and enguages sprint in both the animator and motor.
    /// </para>
    /// </summary>
    [RequireComponent(typeof(PlayerMovement), typeof(PlayerAnimator), typeof(PlayerInput))]
    
    public class PlayerControls : MonoBehaviour
    {
        private readonly float INTERACT_DISTANCE = 0.4f;
        private enum ControlState
        {
            Moving,
            Attacking,
            Converse,
            Store,
            Menu,
            Crafting
        };
        private ControlState _state;

        private PlayerMovement _mover;
        private PlayerAnimator _anima;
        private PlayerInput _playerInput;

        // Start is called before the first frame update
        void Start()
        {
            _mover = GetComponent<PlayerMovement>();
            _anima = GetComponent<PlayerAnimator>();
            _playerInput = GetComponent<PlayerInput>();

            _state = ControlState.Moving;
        }
        public void OnMovement(InputValue MovementValue)
        {
            Vector2 moveVec = MovementValue.Get<Vector2>();
            if(moveVec != Vector2.zero)
            {
                _anima.BeginMovement();
            }
            else
            {
                _anima.EndMovement();
            }
            _mover.TakeInput(moveVec);
            _anima.SetDirection(moveVec);
        }
        public void OnRun(InputValue RunBool)
        {
            if(!RunBool.isPressed)
            {
                _mover.sprintState(false);
            }
            else
            {
                _mover.sprintState(true);
            }
        }
       public void OnInteract()
        {
            Debug.Log("Inreacting");
            RaycastHit2D hits;
            switch (_anima.DirectionCheck)
            {
                case 1:
                    hits = Physics2D.Raycast(transform.position, Vector2.right, INTERACT_DISTANCE);
                    break;
                case 2:
                    hits = Physics2D.Raycast(transform.position, Vector2.up, INTERACT_DISTANCE);
                    break;
                case 3:
                    hits = Physics2D.Raycast(transform.position, Vector2.left, INTERACT_DISTANCE);
                    break;
                default:
                    hits = Physics2D.Raycast(transform.position, Vector2.down, INTERACT_DISTANCE*2.5f);
                    break;
            }
            Debug.Log(hits.collider.name);
        }
        public void OnAttack()
        {

        }

        private bool ContainsAnID(Collider2D collider)
        {
            if (collider.GetComponent<ItemSystem.Chest>())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}