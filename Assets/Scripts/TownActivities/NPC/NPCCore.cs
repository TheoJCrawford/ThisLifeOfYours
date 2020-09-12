﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TLY.Animation;
using TLY.Controls;
using UnityEngine;

namespace TLY.TownActivities.NPC
{
    [RequireComponent(typeof(NPCAnimator))]
    public class NPCCore : MonoBehaviour
    {
        [SerializeField]public string npcName { get; set; }
        [SerializeField] public string gender { get; internal set; }
        public int relation { get; internal set; }
        [SerializeField] public string IntroductionLine { get; set; }
        [SerializeField] public List<string> dialoguelines { get; set; }
        public bool hasMet { get; internal set; }

        

        internal NPCAnimator _anima;

        private void Awake()
        {
            _anima = GetComponent<NPCAnimator>();
        }

        public NPCCore()
        {
            npcName = "Greg";
            gender = "Male";
            relation = 0;
            hasMet = false;
            IntroductionLine = "Hello, my name is Greg. \n Have we met before?";
            dialoguelines = new List<string>();
        }

        public virtual void Speak(int direct)
        {
            _anima.SetDirection(direct);
            if (!hasMet)
            {
                if (GameObject.Find("Deus"))
                {
                    Debug.Log("We found god!");
                }
                GameObject.Find("Deus").GetComponent<UI.UIHandler>().ModifyText(IntroductionLine);

                hasMet = true;
            }
            else
            {
                GameObject.Find("Deus").GetComponent<UI.UIHandler>().ModifyText(dialoguelines.ElementAt(RandomizeLines()));
                Debug.Log(dialoguelines.ElementAt(RandomizeLines()));            
            }
            
        }
        #region In Editor lines
        public void ChangeGender(int NewGender)
        {
            switch (NewGender)
            {
                case 0:
                    gender = "Male";
                    break;
                case 1:
                    gender = "Female";
                    break;
                case 2:
                    gender = "Unknown";
                    break;
                default:
                    Debug.Log("Dafuq?");
                    break;
            }
        }

        private int RandomizeLines()
        {
            System.Random randy = new System.Random();
            if(dialoguelines.Count > 0)
            {
                return randy.Next(0, dialoguelines.Count - 1);
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
