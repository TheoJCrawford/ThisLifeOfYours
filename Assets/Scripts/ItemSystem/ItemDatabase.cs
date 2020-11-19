using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace TLY.ItemSystem
{
    [System.Serializable]
    public class ItemDatabase
    {
        private const string FILE_PATH = "Asset/Database";
        private const string FOLDER_NAME = "Database";
        private const string FILE_NAME = "Item Databases.json";

        public List<baseItem> Items;
        public List<MeleeWeapon> mWeapons;
        public List<RangedWeapon> rWeapons;
        public List<Armor> Armours;

        public void Initialize()
        {
            Items = new List<baseItem>();
            mWeapons = new List<MeleeWeapon>();
            rWeapons = new List<RangedWeapon>();
        }

        public void SaveDatabase()
        {
            string[] tempSave = { JsonUtility.ToJson(Items), JsonUtility.ToJson(mWeapons), JsonUtility.ToJson(rWeapons), JsonUtility.ToJson(Armours)};
            string finalSave = JsonUtility.ToJson(tempSave);
            Debug.Log(finalSave);
        }
        public void LoadItems()
        {
            StreamReader reader = new StreamReader(FILE_PATH + FILE_NAME,true);
            if (reader == null)
            {
                Initialize();
                return;
            }
            else
            {
                string file = reader.ReadToEnd();
                string[] tempLoad = JsonUtility.FromJson<string[]>(file);

                Items = JsonUtility.FromJson<List<baseItem>>(tempLoad[0]);
                mWeapons = JsonUtility.FromJson<List<MeleeWeapon>>(tempLoad[1]);
                rWeapons = JsonUtility.FromJson<List<RangedWeapon>>(tempLoad[2]);
                Armours = JsonUtility.FromJson<List<Armor>>(tempLoad[3]);
            }
        }
    }
}
