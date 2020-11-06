using System;
using System.Collections.Generic;
using UnityEngine;
using TLY.ItemSystem;
using TLY.SkillSystem;

namespace TLY.Core
{
    [Serializable]
    [CreateAssetMenu(fileName ="SaveData", menuName ="This Life of yours/Character Save")]
    public class SaveData:ScriptableObject
    {
        public string charName;
        [SerializeField]public Gender gender;

        [Header("Core Stats")]

        [SerializeField] protected int maxHealth;
        
        [SerializeField] protected int maxStamina;
        


        [SerializeField] private Inventory inventory;
        [SerializeField] private List<SkillBlock> skills;

        public string CharName { get => charName; set => charName = value; }
        public int MaxHealth { get => maxHealth; }
        public int MaxStamina { get; internal set; }
        public Inventory Invent { get => inventory; }
        public List<SkillBlock> Skills { get => skills; }

        public SaveData()
        {
            charName = "Lennom";
            gender = 0;
            maxHealth = 100;
            maxStamina = 100;

            inventory = new Inventory();
            skills = new List<SkillBlock>();
        }


        public void ChangeName(string NewName)
        {
            charName = NewName;
        }


        public void ModifyMaxHealth(int Modifier)
        {
            maxHealth += Modifier;
        }
        public void ModifyMaxStamina(int Modifier)
        {
            MaxStamina += Modifier;
        }
    }
    public enum Gender
    {
        Male,
        Female,
        Unknown
    };
}
