using UnityEditor;
using System.Collections.Generic;
using UnityEngine;
using TLY.SkillSystem;
using System;

namespace TLY.Core
{
    public class PlayerData : MonoBehaviour
    {
        public string charName { get; set; }
        public Gender gender { get; set; }

        public Vital Health { get; set; }
        public Vital Stamina { get; set; }
        public int attack { get; set; }
        public int defence { get; set; }
        public int magic { get; set; }
        public int speed { get; set; }
        public List<SkillBlock> Skills {get; internal set; }
        public Inventory inventory { get; internal set; }

        
        public SaveData save;

        private void Awake()
        {
            if(save != null)
            {
                charName = save.CharName;
                Skills = save.Skills;
            }
            else
            {
                Health = new Vital("Health");
                Stamina = new Vital("Stamina");
                Skills = new List<SkillBlock>();
                inventory = new Inventory();
                attack = 0;
                defence = 0;
                magic = 0;
            }
        }

        public void ModifyHealth(int Val)
        {
            /*
             * When firing this function: 
             * For damage, Val must be negative
             * For healing, Val must be positive
             */
        }
        public void ModifyStamina(int Val)
        {
            
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