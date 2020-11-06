using UnityEngine.UI;
using UnityEngine;
using TLY.Controls;
using TLY.TownActivities.NPC;
using TLY.Core;

namespace TLY.UI
{
   public class UIHandler:MonoBehaviour
    {
        #region UI
        [SerializeField] Text _txtDisplay;
        [SerializeField] GameObject _lowerTab;
        [SerializeField] Button _trainerButoon;
        [SerializeField] Image _healthBar;
        #endregion

        [SerializeField] PlayerData _player;

        public GameObject _targetName;
        private void Start()
        {
            if(_player == null)
            {
                Debug.LogError("THE FUCK YOU DOING?! NO PLAYER ATTACHED!");
                Debug.Break();
            }
            if(_txtDisplay == null)
            {
                Debug.LogError("No text for txt_Display");
                Debug.Break();
            }
            if(_lowerTab == null)
            {
                Debug.LogError("There is no lower pannel.");
                Debug.Break();
            }
            if(_healthBar == null)
            {
                Debug.LogError("There's no health bar");
                Debug.Break();
            }
            _txtDisplay.text = " ";
            _lowerTab.SetActive(false);
            _trainerButoon.gameObject.SetActive(false);
            _healthBar.fillAmount = _player.curHealth / _player.maxHealth;

        }

        private void Update()
        {
            _healthBar.fillAmount = _player.curHealth / _player.maxHealth;  
        }
        internal void EnguageTrainerOption(GameObject target)
        {
            _targetName = target;
            _trainerButoon.gameObject.SetActive(true);
        }
        public void LearnNewSkill()
        {
            
            if (_targetName.TryGetComponent(out BlacksmithTeacher  test))
            {
                Debug.Log("Found the Blacksmith trainer!!");
                _player.AddNewSkillBlock(test.TrainSkill());

            }
            
        }
        public void ModifyText(string NewText)
        {
            if(_txtDisplay.text != NewText)
            {
                _lowerTab.SetActive(true);
                _txtDisplay.text = NewText;
            }
        }
        public void EnterDialogue()
        {
            _lowerTab.SetActive(true);
        }
        public void ExitDialogue()
        {
            _targetName = null;
            _player.GetComponent<PlayerControls>().LeaveConversation();
            _lowerTab.SetActive(false);
        }
    }
}
