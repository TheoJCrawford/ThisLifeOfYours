using UnityEngine;
using UnityEditor;

namespace TLY.SkillSystem
{
    public class SkillDatabaseEditor:EditorWindow
    {
        public const float ICON_BUTTON_SIZE = 50f;
        
        private SkillBlockDb _skillDB;
        private int _indexer = -1;


        private string _skillName;
        private string _descript;
        private string _spriteAdress;
        private SkillType _skillType;
        private GUIContent _buttonIcon;

        [MenuItem("TLOY / Skill DB Editor")]
        public static void ShowWindow()
        {
            EditorWindow window = GetWindow(typeof(SkillDatabaseEditor));
            window.minSize = new Vector2(600, 500);
            window.name = "Skill Block Editor";
        }
        private void OnEnable()
        {
            _skillDB = SkillBlockDb.InstantiateSkillBlock();
            ResetSkill();
            _buttonIcon = new GUIContent();
        }
        private void OnGUI()
        {
            SideBar();
            MainSection();
        }
        private void SideBar()
        {
            GUILayout.BeginArea(new Rect(0, 0, 145, 500));
            if(GUILayout.Button("Reset Skill"))
            {
                ResetSkill();
            }
            if(GUILayout.Button("Save Database"))
            {
                _skillDB.SaveSkillBlock();
                ResetSkill();
            }
            if(_skillDB.GetCount > 0)
            {
                for (int i = 0; i < _skillDB.GetCount; i++)
                {
                    if (GUILayout.Button(_skillDB.SkillName(i)))
                    {
                        _indexer = i;
                        _skillName = _skillDB.SkillName(_indexer);
                        _descript = _skillDB.SkillDescription(_indexer);
                        _buttonIcon.image = _skillDB.SkillIconTexture(_indexer);
                        _spriteAdress = AssetDatabase.GetAssetPath(_buttonIcon.image);
                        _skillType = _skillDB.GetSkillType(_indexer);
                    }
                }
            }
            GUILayout.EndArea();
        }
        private void MainSection()
        {
            GUILayout.BeginArea(new Rect(150, 10, 440, 500));
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
                EditorGUIUtility.ShowObjectPicker<Texture>(_buttonIcon.image, false, "", 0);
            }
            if(Event.current.commandName == "ObjectSelectorUpdated")
            {
                _buttonIcon.image = (Texture)EditorGUIUtility.GetObjectPickerObject();
                _spriteAdress = AssetDatabase.GetAssetPath(_buttonIcon.image);
                _spriteAdress = _spriteAdress.Replace("Assets/Resources/", "");
                _spriteAdress = _spriteAdress.Replace(".png", "");
            }
            _skillType = (SkillType)EditorGUILayout.EnumPopup(_skillType);
            if (GUILayout.Button("Save Item"))
            {
                if(_indexer == -1)
                {
                    _skillDB.AddSkillBlock(_skillName, _descript, _spriteAdress, _skillType);
                    ResetSkill();
                }
                else
                {
                    _skillDB.EditSkillBlock(_indexer, _skillName, _descript, _spriteAdress, _skillType);                    
                }
                
            }
        }

        private void ResetSkill()
        {
            _indexer = -1;
            _skillName = " ";
            _descript = " ";
            _spriteAdress = " ";
            _buttonIcon = new GUIContent();
        }

    }
}
