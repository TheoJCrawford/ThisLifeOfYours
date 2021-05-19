using UnityEngine;
using TLY.Movement;
using TLY.Animation;
using UnityEngine.InputSystem;  


namespace TLY.Controls
{
    [RequireComponent(typeof(PlayerMovement), typeof(PlayerAnimator), typeof(PlayerInput))]
    
    public class PlayerControls : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
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

        private Vector2 _moveDirect;
        private PlayerMovement _mover;
        private PlayerAnimator _anima;

        private InputAction _moveAction;
        private InputAction _spirntAction;

        // Start is called before the first frame update
        void Start()
        {
            _mover = GetComponent<PlayerMovement>();
            _anima = GetComponent<PlayerAnimator>();
            _playerInput = GetComponent<PlayerInput>();

            _moveAction = _playerInput.actions.FindAction("Movement");
            _spirntAction = _playerInput.actions.FindAction("Run");

            _state = ControlState.Moving;
        }

        private void Update()
        {
            _moveAction.performed += TakeMoveInput;
            _spirntAction.performed += TakeSprintInput;
            _moveAction.canceled += TakeMoveInput;
            _spirntAction.canceled += TakeSprintInput;
        }

        private void TakeMoveInput(InputAction.CallbackContext context)
        {
            _mover.TakeInput(context.ReadValue<Vector2>());
        }
        private void TakeSprintInput(InputAction.CallbackContext context)
        {
            if(context.ReadValue<float>() > 0){
                _mover.sprintState(true);
            }
            else
            {
                _mover.sprintState(false);
            }
            
        }
    }
}