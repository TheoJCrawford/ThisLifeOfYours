﻿using UnityEngine.UI;

namespace TLY.SkillSystem
{
    public class SkillBlock
    {
        public string name { get; internal set; }
        public string descript { get; internal set; }
        public Image icon { get; internal set; }
        public int level { get; internal set; }

        public int expToLvel { get; internal set; }
        public int expPool { get; internal set; }
        public int exhaust { get; internal set; }

        public SkillBlock()
        {
            name = "Martial";
            LearnSkillBlock();
            level = 1;
            expToLvel = 1000;
            expPool = 0;
            exhaust = 0;
        }

        private void LearnSkillBlock()
        {
            switch (name)
            {
                case "Thievery":
                    descript = "Stealing and moving quietly on the job.";
                    break;
                case "Thaumatergy":
                    descript = "The construction of aether manipulating gear as well as research";
                    break;
                case "Faith":
                    descript = "The will of the gods, helping within the temple, all things todo with the greater faith";
                    break;
                case "Leatherwork":
                    descript = "The ability to make some armours and shoes";
                    break;
                case "Alchemy":
                    descript = "The ability to make potoins and poisons";
                    break;
                case "Performance":
                    descript = "Singing in bars, acting on the stage.";
                    break;
                case "Mechantilism":
                    descript = "The ability to barter better.";
                    break;
                case "Tinker":
                    descript = "The construction of new items not commonly used.";
                    break;
                case "Occult":
                    descript = "With eldritch horrors, create and destroy";
                    break;
                case "Tailor":
                    descript = "For the making of clothing and other wares";
                    break;
            }
        }
        public void GainExperience(int Val)
        {
            if(exhaust > 0)
            {
                expPool += Val / exhaust + 1;
            }
            else
            {
                expPool += Val;
            }
            if(expPool >= expToLvel)
            {
                LevelUp();
            }
        }
        private void LevelUp()
        {
            level++;
            expToLvel += level * 1000;
        }
    }
    public enum SkillName
    {
        Martial,                //Join the war and fight the problems? Join the local military and help fight for your lord!
        Brawling,               //Apply fist to face(s)
        Thievery,               //I heard you like making money... Care if others lose a bit of coin every now and then?
        Thaumatergy,            //Magic is an interesting topic, thus the study is required. So, how can we get it to work?
        Faith,                  //To the divine, we give unto thee. Smite the heretics from all that was and will
        Blacksmith,             //The forge calls, so I make it unbreaking
        Leatherwork,            //Leathers for those who no longer need cows
        Tailor,                 //Clothes and clothwork for those with the coin to purchase it
        Alchemy,                //Potions and tonics for all! Well, if you need a poison on the other hand...
        Performance,            //Poetry? Music? Go forth!
        Mercantilism,           //I heard you like making money, thus trade away!
        Tinker,                 //Somethings are not yet ready for this world, but these things you are putting together... they are strange, no?
        Occult,                 //Demons, eldritch horrors, what's not to love?
    };
}
