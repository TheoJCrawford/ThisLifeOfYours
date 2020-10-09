using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;
using TLY.Controls;
using TLY.TownActivities.NPC;

namespace TLY.UI
{
   public class UIHandler:MonoBehaviour
    {
        
        [SerializeField] Text txtDisplay;
        [SerializeField] GameObject LowerTab;
        [SerializeField] Button trainerButoon;

        private string _targetName;
        private void Start()
        {
            if(txtDisplay == null)
            {
                Debug.LogError("No text for txt_Display");
                Debug.Break();
            }
            if(LowerTab == null)
            {
                Debug.LogError("There is no lower pannel.");
                Debug.Break();
            }
            
            txtDisplay.text = " ";
            LowerTab.SetActive(false);
            trainerButoon.gameObject.SetActive(false);
        }

        internal void EnguageTrainerOption()
        {
            
        }

        public void ModifyText(string NewText)
        {
            if(txtDisplay.text != NewText)
            {
                LowerTab.SetActive(true);
                txtDisplay.text = NewText;
            }
        }
        public void EnterDialogue(NPCCore NPC)
        {
            _targetName = NPC.name;
            LowerTab.SetActive(true);
        }
        public void ExitDialogue()
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControls>().LeaveConversation();
            LowerTab.SetActive(false);
        }
    }
}
