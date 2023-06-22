using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterDialogueEditor:EditorWindow
    {
    public List<(byte, string)> dialogueLines;
    private LanguageList languageState;

    [MenuItem("TLOY/Dialogue DB Editor")]
    public static void ShowWindow()
    {
        CharacterDialogueEditor editor = new CharacterDialogueEditor();
        editor.Show();
    }
    void OnGUI()
    {
        languageState = (LanguageList)EditorGUILayout.EnumPopup("Language selected: ",languageState, GUILayout.ExpandWidth(false));
        GUILayout.Label("Character Name");
        GUILayout.TextField("");
        //EditorGUILayout.EnumPopup
        EditorGUILayout.IntField(0);
        GUILayout.TextArea("");
        if (GUILayout.Button("Submit"))
        {

        }
    }
    private void Sumbit()
    {

    }

    private enum LanguageList
    {
        EN,
        FR,
        日本,
    };
}
