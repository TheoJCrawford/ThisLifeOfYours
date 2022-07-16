using System;
using UnityEngine;

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

        internal void SetDriftLocation(Transform parent)
        {
            transform.position = Vector3.MoveTowards(transform.position, parent.position,0f);
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
            UpdateItemSprite();
        }
        public void UpdateItemSprite()
        {
            _spRender.sprite = GameObject.Find("Deus").GetComponent<DbHandler>().RetrieveSprite(_itemValue);
        }
        public static void InstaniateFloorItem(int itemValue)
        {
            GameObject target = GameObject.Instantiate(new GameObject());
            target.tag = "Item";
            FloorItem item = target.AddComponent<FloorItem>();
            item._itemValue = itemValue;
            item.UpdateItemSprite();
        }
    }
}
