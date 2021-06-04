﻿using UnityEngine;

namespace TLY.ItemSystem
{
    [RequireComponent(typeof(SpriteRenderer), typeof(CircleCollider2D))]
    public class FloorItem:MonoBehaviour
    {
        [SerializeField] private int _itemValue;
        private SpriteRenderer _spRender;

        public int item => _itemValue;

        public FloorItem(int Item = 0)
        {
            _itemValue = Item;
        }

        private void Start()
        {
            _spRender = GetComponent<SpriteRenderer>();
            //Failsafe
            if (_itemValue >= GameObject.Find("Deus").GetComponent<DbHandler>().GetDbSize)
            {
                Debug.LogError("Item is outside of restraights");
                Debug.Break();
            }
            //Change the sprite render to match the item sprite
            _spRender.sprite = GameObject.Find("Deus").GetComponent<DbHandler>().RetrieveSprite(_itemValue);
        }
    }
}
