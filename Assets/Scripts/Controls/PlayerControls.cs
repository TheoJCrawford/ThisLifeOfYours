using UnityEngine;
using TLY.Movement;
using TLY.Animation;
using UnityEngine.InputSystem;  


namespace TLY.Controls
{
    [RequireComponent(typeof(PlayerMovement), typeof(PlayerAnimator), typeof(PlayerInput))]
    
    public class PlayerControls : MonoBehaviour
    {
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

        private InputAction _moveAction;
        private InputAction _spirntAction;
        private InputAction _interAction;

        // Start is called before the first frame update
        void Start()
        {
            _mover = GetComponent<PlayerMovement>();
            _anima = GetComponent<PlayerAnimator>();
            _playerInput = GetComponent<PlayerInput>();

            _moveAction = _playerInput.actions.FindAction("Movement");
            _spirntAction = _playerInput.actions.FindAction("Run");
            _interAction = _playerInput.actions.FindAction("Interact");

            _state = ControlState.Moving;
        }

        private void Update()
        {
            _moveAction.performed += TakeMoveInput;
            _spirntAction.performed += TakeSprintInput;
            _interAction.performed += TakeInteractionInput;
            _moveAction.canceled += TakeMoveInput;
            _spirntAction.canceled += TakeSprintInput;
            _interAction.canceled += TakeInteractionInput;
        }

        private void TakeMoveInput(InputAction.CallbackContext context)
        {
            _mover.TakeInput(context.ReadValue<Vector2>());
            _anima.SetDirection(context.ReadValue<Vector2>());
            if(context.ReadValue<Vector2>() != Vector2.zero)
            {
                _anima.BeginMovement();
            }
            else
            {
                _anima.EndMovement();
            }
        }
        private void TakeSprintInput(InputAction.CallbackContext context)
        {
            if(context.ReadValue<float>() != 0){
                _mover.sprintState(true);
                _anima.SetSpritState(true);
            }
            else
            {
                _mover.sprintState(false);
                _anima.SetSpritState(false);
            }
            
        }
        private void TakeInteractionInput(InputAction.CallbackContext context)
        {
            RaycastHit2D hits;
            if (context.ReadValue<float>() != 0)
            {
                switch (_anima.DirectionCheck)
                {
                    case 1:
                        hits = Physics2D.Raycast(transform.position, Vector2.left);
                        break;
                    case 2:
                        hits = Physics2D.Raycast(transform.position, Vector2.up);
                        break;
                    case 3:
                        hits = Physics2D.Raycast(transform.position, Vector2.right);
                        break;
                    default:
                        hits = Physics2D.Raycast(transform.position, Vector2.down);
                        break;
                }
                if (hits.collider.GetComponent<TownActivities.NPC.NPCCore>())
                {

                }

            }

        }
    }
}