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
        [SerializeField] protected Vital health;
        


        [SerializeField] private Inventory inventory;
        [SerializeField] private List<SkillBlock> skills;

        public string CharName { get => charName; set => charName = value; }
        public Vital Health => health;
        public Vital Stamina { get; internal set; }
        public Inventory Invent { get => inventory; }
        public List<SkillBlock> Skills { get => skills; }

        public SaveData()
        {
            charName = "Lennom";
            gender = 0;
            health = new Vital("Health");
            Stamina = new Vital("Stamina");
            inventory = new Inventory();
            skills = new List<SkillBlock>();
        }


        public void ChangeName(string NewName)
        {
            charName = NewName;
        }


        public void ModifyMaxHealth(int Modifier)
        {
            health.ModifyMaxVital(Modifier);
        }
        public void ModifyMaxStamina(int Modifier)
        {
        
        }
    }
    public enum Gender
    {
        Male,
        Female,
        Unknown
    };
}
