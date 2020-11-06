using UnityEditor;
using System.Collections.Generic;
using UnityEngine;
using TLY.ItemSystem;
using TLY.SkillSystem;
using System;
using UnityEditorInternal;

namespace TLY.Core
{
    public class PlayerData : MonoBehaviour
    {
        public string charName { get; set; }
        public Gender gender { get; set; }
        public int curHealth { get; internal set; }
        public int maxHealth { get; internal set; }
        public int curStamina { get; internal set; }
        public int maxStamina { get; internal set; }
        public Inventory inventory { get; internal set; }
        public List<SkillBlock> Skills {get; internal set; }

        
        public SaveData save;

        private void Awake()
        {
            if(save != null)
            {
                charName = save.CharName;
                maxHealth = save.MaxHealth;
                curHealth = maxHealth;
                maxStamina = save.MaxStamina;
                curStamina = maxStamina;
                inventory = save.Invent;
                Skills = save.Skills;
            }
            else
            {
                maxHealth = 100;
                curHealth = maxHealth;
                maxStamina = 100;
                inventory = new Inventory();
                Skills = new List<SkillBlock>();
            }
        }

        public void ModifyHealth(int Val)
        {
            /*
             * When firing this function: 
             * For damage, Val must be positive
             * For healing, Val must be negative
             */
            if(curHealth - Val < 0)
            {
                curHealth = 0;
            }
            else if( curHealth - Val >= maxHealth)
            {
                curHealth = maxHealth;
            }
            else
            {
                curHealth -= Val;
            }
        }

        public void AddNewSkillBlock( SkillBlock newSkill){
            if (Skills.Contains(newSkill))
            {
                return;
            }
            else
            {
                Skills.Add(newSkill);
            }
        }

    }
}