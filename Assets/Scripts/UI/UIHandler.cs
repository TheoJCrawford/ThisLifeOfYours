using UnityEngine.UI;
using UnityEngine;
using TLY.Controls;
using TLY.TownActivities.NPC;
using TLY.Core;
using System;

namespace TLY.UI
{
   public class UIHandler:MonoBehaviour
    {
        #region UI
        
        [SerializeField] private GameObject _lowerTab;
        [SerializeField] private GameObject _itemTab;
        [SerializeField] private Button _trainerButoon;
        [SerializeField] private Text _txtDisplay;
        [SerializeField] private Text _healthBar;
        [SerializeField] private Text _staminahBar;
        #endregion

        [SerializeField] private PlayerData _player;

        public NPCCore _targetName;
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
            //_trainerButoon.gameObject.SetActive(false);
            _itemTab.SetActive(false);
            _healthBar.text =  "Health: "+ _player.Health.ToString();
            _staminahBar.text = "Stamina: " + _player.Stamina.ToString();

        }

        private void Update()
        {
            _healthBar.text = _player.Health.VitalName + _player.Health.ToString();
            _staminahBar.text = "Stamina: " + _player.Stamina.ToString();
        }
        internal void EnguagePerson(NPCCore npc)
        {
            _targetName = npc;
            if (_targetName.GetComponent<NPCCore>().hasMet &&_targetName.GetType().IsAssignableFrom(typeof(SkillTrainer)))
            {
                EnterDialogue();
                SkillTrainer trainer = (SkillTrainer)_targetName;
                ModifyText(trainer.inquiryLine);
                _trainerButoon.gameObject.SetActive(true);
            }
            if (_targetName.GetComponent<NPCCore>().hasMet)
            {
                EnterDialogue();
                ModifyText(_targetName.dialoguelines.Count.ToString());
            }
            else
            {
                EnterDialogue();
                ModifyText(npc.IntroductionLine);
                _trainerButoon.gameObject.SetActive(false);
            }
        }
        public void LearnNewSkill()
        {
            SkillTrainer trainer = (SkillTrainer)_targetName;
                Debug.Log("Found the Blacksmith trainer!!");
                _player.AddNewSkillBlock(trainer.TrainSkill());

            
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
        public void CharacterScreenOn()
        {
            if (!_itemTab.activeSelf)
            {
                _itemTab.SetActive(true);
            }
            else
            {
                _itemTab.SetActive(false);
            }
        }
        
        private void ModifyText(string NewText)
        {
            if (_txtDisplay.text != NewText)
            {
                _txtDisplay.text = NewText;
            }
        }
    }
}
