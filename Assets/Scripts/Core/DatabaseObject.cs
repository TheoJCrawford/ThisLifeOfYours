using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class DatabaseObject<T> where T : ScriptableObject
{
    private const string FOLDER_LOCATION = "Assets/Database";

    
    private static List<T> database;

    
    public static int GetSize => database.Count;
    public static void AddObject(T item)
    {
        database.Add(item);
    }
    public static T GetObject(int item)
    {
        return database.ElementAt(item);
    }
    public static void RemoveObject(int item)
    {
        database.RemoveAt(item);
    }
    
    public static void Initialization()
    {
        if(!AssetDatabase.IsValidFolder(FOLDER_LOCATION)){
            AssetDatabase.CreateFolder("Assets", "Databases");
        }
    }

    public static void SaveDatabase()
    {
        string json = JsonUtility.ToJson(database);
        Debug.Log(json);
    }
}
