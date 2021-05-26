using UnityEngine;

namespace TLY.ItemSystem
{
    [RequireComponent(typeof(SpriteRenderer))]
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
            //Change the sprite render to match the texture
            _spRender.sprite = GameObject.Find("Deus").GetComponent<DbHandler>().RetrieveSprite(_itemValue);
        }
    }
}
