using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DbHandler : MonoBehaviour
{
    ItemDatabase itemDb;
    void Start()
    {
        itemDb = ItemDatabase.InstantiateItemDatabase();
    }

    public Texture RetrieveSprite(int sprite)
    {
        return itemDb.ReturnItemSprite(sprite);
    }
}
