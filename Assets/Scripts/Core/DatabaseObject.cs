using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class DatabaseObject<T> where T : ScriptableObject
{
    private const string FOLDER_LOCATION = "Assets/Database";

    
    private  List<T> database;

    
    public int GetSize => database.Count;
    public  void AddObject(T item)
    {
        database.Add(item);
    }
    public  T GetObject(int item)
    {
        return database.ElementAt(item);
    }
    public  void RemoveObject(int item)
    {
        database.RemoveAt(item);
    }
    
    public  void Initialization()
    {
        if(!AssetDatabase.IsValidFolder(FOLDER_LOCATION)){
            AssetDatabase.CreateFolder("Assets", "Databases");
        }
    }

    public  void SaveDatabase()
    {
        string json = JsonUtility.ToJson(database);
        Debug.Log(json);
    }
}
