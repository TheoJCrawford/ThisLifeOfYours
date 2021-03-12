using UnityEngine;

namespace TLY.ItemSystem
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class FloorItem:MonoBehaviour
    {
        private int _itemValue;
        private SpriteRenderer _spRender;

        public int item => _itemValue;

        public FloorItem(int Item)
        {
            _itemValue = Item;
        }

        private void Awake()
        {
            _spRender = GetComponent<SpriteRenderer>();
            //Change the sprite render to match the texture
        }
    }
}
