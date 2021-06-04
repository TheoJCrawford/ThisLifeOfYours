using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DbHandler : MonoBehaviour
{
    ItemDatabase itemDb;

    public Sprite RetrieveSprite(int sprite) => itemDb.ReturnItemSprite(sprite);
    public int GetDbSize => itemDb.DbSize;

    void Awake()
    {
        itemDb = ItemDatabase.InstantiateItemDatabase();
    }

    
}
