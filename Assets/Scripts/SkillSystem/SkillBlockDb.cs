using System.Data;
using System.IO;
using UnityEngine;


namespace TLY.SkillSystem
{
    public class SkillBlockDb
    {
        DataTable _skillBocks;

        public int GetCount => _skillBocks.Rows.Count;
        #region Returns
        public string SkillName(int ID) => _skillBocks.Rows.Find(ID)["Name"].ToString();
        public string SkillDescription(int ID) => _skillBocks.Rows.Find(ID)["Description"].ToString();
        public string SkillIconPath(int ID) => _skillBocks.Rows.Find(ID)["Sprite Adress"].ToString();
        public Texture SkillIcon(int ID) => Resources.Load<Texture>(_skillBocks.Rows.Find(ID)["Sprite Adress"].ToString());
        public SkillType GetSkillType(int ID) => (SkillType)_skillBocks.Rows.Find(ID)["Skill Type"];
        #endregion
        private void CreateSkillBlock()
        {
            _skillBocks = new DataTable();
            var primaryKeys = new DataColumn[1];
            _skillBocks.TableName = "Skill Blocks-EN";

            #region ID
            DataColumn dataColumn = new DataColumn();
            dataColumn.ColumnName = "ID";
            dataColumn.DataType = typeof(int);
            dataColumn.AutoIncrement = true;
            dataColumn.AutoIncrementSeed = 0;
            dataColumn.AutoIncrementStep = 1;
            dataColumn.ReadOnly = true;
            _skillBocks.Columns.Add(dataColumn);
            primaryKeys[0] = dataColumn;
            #endregion
            #region Name
            DataColumn dataColumn1 = new DataColumn();
            dataColumn1.ColumnName = "Name";
            dataColumn1.DataType = typeof(string);
            dataColumn1.Unique = true;
            _skillBocks.Columns.Add(dataColumn1);
            #endregion
            #region Description
            DataColumn dataColumn2 = new DataColumn();
            dataColumn2.ColumnName = "Description";
            dataColumn2.DataType = typeof(string);
            dataColumn1.Unique = true;
            _skillBocks.Columns.Add(dataColumn2);
            #endregion
            #region Sprite
            DataColumn dataColumn3 = new DataColumn();
            dataColumn3.ColumnName = "Sprite Adress";
            dataColumn3.DataType = typeof(string);
            dataColumn3.Unique = true;
            _skillBocks.Columns.Add(dataColumn3);
            #endregion
            #region Type of Skill
            DataColumn dataColumn4 = new DataColumn();
            dataColumn4.ColumnName = "Skill Type";
            dataColumn4.DataType = typeof(SkillType);
            _skillBocks.Columns.Add(dataColumn4);
            #endregion
            #region
            //Additional things
            #endregion

            _skillBocks.PrimaryKey = primaryKeys;
        }
        private void PopulateSkillBlock()
        {
            if (File.Exists("Assets/Database/SkillsDB.xml"))
            {
                using (StreamReader reader = new StreamReader("Assets/Database/SkillsDB.xml"))
                {
                    _skillBocks.ReadXml(reader);
                }
            }
        }
        public void SaveSkillBlock()
        {
            using(StreamWriter writer = new StreamWriter("Assets/Database/SkillsDB.xml"))
            {
                _skillBocks.WriteXml(writer);
            }
        }
        public static SkillBlockDb InstantiateSkillBlock()
        {
            SkillBlockDb self = new SkillBlockDb();
            self.CreateSkillBlock();
            self.PopulateSkillBlock();
            return self;
        }
        public void AddSkillBlock(string Name, string Descript, string SpriteID, SkillType SkillType)
        {
            if (SpriteID == " " || Name == " "|| Descript == " ")
            {
                Debug.LogError("This has no Sprite adress");
                return;
            }
            DataRow row = _skillBocks.NewRow();
            row["Name"] = Name;
            row["Description"] = Descript;
            row["Sprite Adress"] = SpriteID;
            row["Skill Type"] = SkillType;
            _skillBocks.Rows.Add(row);
        }
        public void EditSkillBlock(int Id, string Name, string Descript, string SpriteID, SkillType SkillType)
        {
            _skillBocks.Rows.Find(Id)["Name"] = Name;
            _skillBocks.Rows.Find(Id)["Description"] = Descript;
            _skillBocks.Rows.Find(Id)["Sprite Adress"] = SpriteID;
            _skillBocks.Rows.Find(Id)["Skill Type"] = SkillType;
            
        }
    }
    public enum SkillType
    {
        Combat,
        Crafting,
        Action,
    };
}
