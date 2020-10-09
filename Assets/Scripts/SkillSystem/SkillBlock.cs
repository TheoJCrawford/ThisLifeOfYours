using UnityEngine;

namespace TLY.SkillSystem
{
    public class SkillBlock
    {
        protected string name { get;  set; }
        protected string descript { get; set; }
        protected Sprite icon { get; set; }
        protected int level { get; set; }

        protected int expToLvel { get; set; }
        protected int expPool { get; set; }
        protected int exhaust { get; set; }

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
