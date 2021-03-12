using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DbHandler : MonoBehaviour
{
    ItemDatabase itemDb;
    void Start()
    {
        itemDb = new ItemDatabase();
        itemDb.CreateDatatable();
        itemDb.PopulateDatatable();
    }

    public Texture RetrieveSprite(int sprite)
    {
        return itemDb.ReturnItemSprite(sprite);
    }
}
