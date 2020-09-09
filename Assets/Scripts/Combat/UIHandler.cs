using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;

namespace TLY.UI
{
   public class UIHandler:MonoBehaviour
    {
        
        [SerializeField] Text txtDisplay;
        [SerializeField] GameObject LowerTab;

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
        }
        public void ModifyText(string NewText)
        {
            if(txtDisplay.text != NewText)
            {
                LowerTab.SetActive(true);
                txtDisplay.text = NewText;
            }
        }
        public void EnterDialogue()
        {
            LowerTab.SetActive(true);
        }
        public void LeaveText()
        {
            LowerTab.SetActive(false);
        }

        public void ExitDialogue()
        {
            LowerTab.SetActive(false);
        }
    }
}
