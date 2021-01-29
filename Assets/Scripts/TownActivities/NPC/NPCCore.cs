using System;
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
        [SerializeField] public Gender gender { get; internal set; }
        [SerializeField] public int relation { get; internal set; }
        [SerializeField] public int isSingle { get; set; }
        [SerializeField] public string IntroductionLine { get; set; }
        [SerializeField] public List<string> dialoguelines;
        public bool hasMet { get; internal set; }
        public NPCState curState { get; set; }

        private NPCState lastState;

        public enum NPCState
        {
            work,
            talk,
            transit,
            relax
        };
        public enum Gender
    {
        Male,
        Female,
        Unknown
    }

        internal NPCAnimator _anima;

        private void Awake()
        {
            _anima = GetComponent<NPCAnimator>();
        }

        public NPCCore()
        {
            npcName = "Greg";
            gender = Gender.Male;
            relation = 0;
            hasMet = false;
            IntroductionLine = "Hello, my name is Greg. \n Have we met before?";
            dialoguelines = new List<string>();
        }

        public virtual void Speak(int direct)
        {
            lastState = curState;
            curState = NPCState.talk;
            _anima.SetDirection(direct);
            if (!hasMet)
            {
                if (GameObject.Find("Deus"))
                {
                    Debug.Log("We found god!");
                }
                

                hasMet = true;
            }
            else
            {
                Debug.Log(dialoguelines.ElementAt(RandomizeLines()));            
            }
            
        }
        public void LeaveSpeak()
        {
            curState = lastState;
        }
        public void ChhangeState(NPCState newState)
        {

        }
        #region In Editor lines

        public void ChangeGender(Gender newGender)
        {
            gender = newGender;
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
