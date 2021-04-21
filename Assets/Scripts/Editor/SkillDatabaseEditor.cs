using UnityEngine;
using UnityEditor;

namespace TLY.SkillSystem
{
    public class SkillDatabaseEditor:EditorWindow
    {
        public const float ICON_BUTTON_SIZE = 50f;
        private SkillBlockDb _skillDB;

        private string _skillName;
        private string _descript;
        private string _spriteAdress;
        private GUIContent _buttonIcon;

        [MenuItem("TLOY / Skill DB Editor")]
        public static void ShowWindow()
        {
            EditorWindow window = GetWindow(typeof(SkillDatabaseEditor));
            window.minSize = new Vector2(600, 500);
            window.maxSize = new Vector2(600, 500);
        }
        private void OnEnable()
        {
            _skillDB = SkillBlockDb.InstantiateSkillBlock();
            _skillName = " ";
            _buttonIcon = new GUIContent();
        }
        private void OnGUI()
        {
            SideBar();
            MainSection();
        }
        private void SideBar()
        {
            GUILayout.BeginArea(new Rect(1, 5, 95, 500));
            GUILayout.Button("Reset Skill");
            if(GUILayout.Button("Save Database"))
            {
                _skillDB.SaveSkillBlock();
            }
            if(_skillDB.GetCount > 0)
            {
                for (int i = 0; i < _skillDB.GetCount; i++)
                {
                    GUILayout.Button(_skillDB.SkillName(i));
                }
            }
            GUILayout.EndArea();
        }
        private void MainSection()
        {
            GUILayout.BeginArea(new Rect(105, 5, 490, 500));
            GUILayout.BeginHorizontal();
            GUILayout.Label("Name: ", GUILayout.ExpandWidth(false));
            _skillName = GUILayout.TextField(_skillName);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Description: ", GUILayout.ExpandWidth(false));
            _descript = GUILayout.TextField(_descript);
            GUILayout.EndHorizontal();
            GUILayout.Label("Sprite Adress: " + _spriteAdress);
            if(GUILayout.Button(_buttonIcon, GUILayout.MaxWidth(ICON_BUTTON_SIZE), GUILayout.MaxHeight(ICON_BUTTON_SIZE)))
            {
                //EditorGUIUtility.ShowObjectPicker<Sprite>()
            }
            if(GUILayout.Button("Save Item"))
            {
                _skillDB.AddSkillBlock(_skillName, _descript, _spriteAdress);
            }
        }
    }
}
