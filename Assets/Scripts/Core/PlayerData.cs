using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TLY.ItemSystem;
using TLY.SkillSystem;
using System;

[CreateAssetMenu(fileName ="NewCharacter", menuName ="TLY/Create Character", order =1)]
public class PlayerData : ScriptableObject
{

    public string charName { get; internal set; }
    public int maxHealth { get; private set; }
    public int curHealth { get; private set; }
    public string gender { get; internal set; }
    
    public Inventory inventory { get; internal set; }

    public List<SkillBlock> skills { get; internal set; }
    //weapon slot
    //armour slot
    //accessory slot    

    public PlayerData()
    {
        charName = "Lenon";
        maxHealth = 100;
        curHealth = 100;
        inventory = new Inventory();
        skills = new List<SkillBlock>();
    }

    public void ChangeName(string NewName)
    {
        charName = NewName;
    }

    public void ModifyCurHealth (int Adjustment)
    {
        curHealth += Adjustment;
        if( curHealth < 0)
        {
            curHealth = 0;
            //Trigger respawn action
        }
        if(curHealth < maxHealth)
        {
            curHealth = maxHealth;
        }
    }
    public void AddSkills(SkillBlock Skill)
    {
        if (!skills.Contains(Skill))
        {
            skills.Add(Skill);
        }
    }
    public void AddExperience(string SkillName, int exp)
    {
        foreach(SkillBlock skill in skills)
        {
            if(skill.name == SkillName)
            {
                skill.GainExperience(exp);
                break;
            }
        }
    }
}
