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
        [SerializeField] private int gender;

        [Header("Core Stats")]

        [SerializeField] protected int maxHealth;
        
        [SerializeField] protected int maxStamina;
        [SerializeField] private int curStamina;


        [SerializeField] private Inventory inventory;
        [SerializeField] private List<SkillBlock> skills;

        public string CharName { get => charName; }
        public int MaxHealth { get => maxHealth; }
        public int MaxStamina { get; internal set; }

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
        public void ChangeGender(int val)
        {
            gender = Mathf.Clamp(val, 0, 2);
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
}
