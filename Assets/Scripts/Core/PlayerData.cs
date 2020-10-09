using UnityEditor;
using System.Collections.Generic;
using UnityEngine;
using TLY.ItemSystem;
using TLY.SkillSystem;
using System;

namespace TLY.Core
{
    public class PlayerData : MonoBehaviour
    {
        public string charName { get; set; }        
        public int maxHealth { get; set; }

        public int maxStamina { get; set; }
        public Inventory inventory { get;  set; }
        public List<SkillBlock> Skills {get;  set;}

        
        public SaveData save;

        private void Awake()
        {
            if(save != null)
            {
                name = save.CharName;
                maxHealth = save.MaxHealth;
                maxStamina = save.MaxStamina;
            }
        }


    }
}