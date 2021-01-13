using System;
using System.Collections.Generic;
using UnityEngine;
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
        
        [SerializeField] private List<SkillBlock> skills;

        public string CharName { get => charName; set => charName = value; }
        public Vital Health => health;
        public Vital Stamina { get; internal set; }
        public List<SkillBlock> Skills { get => skills; }

        public SaveData()
        {
            charName = "Lennom";
            gender = 0;
            health = new Vital("Health");
            Stamina = new Vital("Stamina");
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
