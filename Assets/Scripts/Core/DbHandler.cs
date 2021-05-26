using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DbHandler : MonoBehaviour
{
    ItemDatabase itemDb;
    void Awake()
    {
        itemDb = ItemDatabase.InstantiateItemDatabase();
    }

    public Sprite RetrieveSprite(int sprite)
    {
        return itemDb.ReturnItemSprite(sprite);
    }
}
