using UnityEngine;
namespace TLY.ItemSystem
{
    [RequireComponent(typeof(Animator))]
    public class ChestAnimator:MonoBehaviour
    {
        private Animator _anima;

        private void Awake()
        {
            _anima = GetComponent<Animator>();
        }
        public void OpenChest()
        {
            _anima.SetBool("IsOpen", true);
        }
        public void CloseChest()
        {
            _anima.SetBool("IsOpen", false);
        }
    }
}