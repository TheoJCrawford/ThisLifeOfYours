using System;
using UnityEngine;

namespace TLY.ItemSystem
{
    public class ItemMagnet:MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.GetComponent<FloorItem>())
            {
                Debug.Log($"Begin picking up {collision.GetComponent<FloorItem>().item.ToString()}");
                collision.GetComponent<FloorItem>().SetDriftLocation(transform.parent);
            }
        }
    }
}
