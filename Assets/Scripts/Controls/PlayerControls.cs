using UnityEngine;
using TLY.Movement;
using TLY.Animation;
using System.Collections;

namespace TLY.Controls
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerAnimator))]
    public class PlayerControls : MonoBehaviour
    {
        private enum ControlState
        {
            Moving,
            Attacking,
            Converse,
            Store,
            Menu,
        };
        private ControlState _state;
        private PlayerMovement _mover;
        private PlayerAnimator _anima;
        

        // Start is called before the first frame update
        void Start()
        {
            _mover = GetComponent<PlayerMovement>();
            _anima = GetComponent<PlayerAnimator>();
            _state = ControlState.Moving;

        }

        // Update is called once per frame
        void Update()
        {
            switch (_state)
            {
                case ControlState.Moving:
                    TakeMoveInput();
                    CombatInput();
                    break;
                case ControlState.Menu:
                    MenuInput();
                    break;
                case ControlState.Converse:
                    TakeTalkInput();
                    break;
                default:
                    Debug.LogError("Oi, you dumb shit! We don't have anything perscribed to this ");
                    break;
            }
            IntractInput();

        }
        private void TakeMoveInput()
        {
            _mover.TakeInput(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if(Input.GetAxis("Vertical") < 0)
            {
                _anima.BeginMovement();
                _anima.SetDirection(0);
            }
            else if(Input.GetAxis("Vertical") > 0)
            {
                _anima.BeginMovement();
                _anima.SetDirection(2);
            }
            else if(Input.GetAxis("Horizontal") < 0)
            {
                _anima.BeginMovement();
                _anima.SetDirection(3);
            }
            else if(Input.GetAxis("Horizontal") > 0)
            {
                _anima.BeginMovement();
                _anima.SetDirection(1);
            }
            else
            {
                _anima.EndMovement();
            }
        }
        private void TakeTalkInput()
        {
            _anima.EndMovement();
        }
        private void IntractInput()
        {
            int _faceMe;
            if(Input.GetKeyDown(KeyCode.E))
            switch (_state)
            {
                case ControlState.Moving:
                        RaycastHit2D ray;
                        switch (_anima.DirectionCheck)
                        {
                            case 1:
                                ray = Physics2D.Raycast(transform.position, Vector2.right, 1f);
                                _faceMe = 3;
                                break;
                            case 2:
                                ray = Physics2D.Raycast(transform.position, Vector2.up, 1f);
                                _faceMe = 0;
                                break;
                            case 3:
                                ray = Physics2D.Raycast(transform.position, Vector2.left, 1f);
                                _faceMe = 3;
                                break;
                            default:
                                ray = Physics2D.Raycast(transform.position, Vector2.down, 1f);
                                _faceMe = 2;
                                break;
                        }
                        if (ray != false)
                        {
                            var target = ray.collider;
                            if (target.GetComponent<TownActivities.NPC.StoreFront>())
                            {

                            }
                            else if (target.GetComponent<TownActivities.NPC.NPCCore>())
                            {
                                
                                target.GetComponent<TownActivities.NPC.NPCCore>().Speak(_faceMe);
                                _state = ControlState.Converse;
                            }
                        }
                    break;
                    case ControlState.Converse:
                        if (Input.GetKeyDown(KeyCode.Escape))
                        {
                            GameObject.Find("Deus").GetComponent<UI.UIHandler>().ExitDialogue();
                            _state = ControlState.Moving;
                        }
                        
                        break;
                default:
                    Debug.LogError("Oi, you dumb shit! We don't have anything perscribed to this ");
                    break;
            }
            
        }
        private void CombatInput()
        {
            if (Input.GetAxis("Fire1") > 0)
            {
                //Combat.Attack
            }
        }
        private void MenuInput()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if(_state != ControlState.Menu)
                {
                    _state = ControlState.Menu;
                }
                else
                {
                    _state = ControlState.Moving;
                }
            }
        }

        public void LeaveConversation()
        {
            _state = ControlState.Moving;
        }
    }
}