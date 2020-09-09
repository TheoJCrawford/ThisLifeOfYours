using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    // Start is called before the first frame update
    private void Awake()
    {
        if (_player == null)
        {
            print("Ummm... fuck you, there is no player attached");
        }
        if (GameObject.FindGameObjectWithTag("Player") == null) 
        {
            GameObject.Instantiate(_player); 
        }
    }
}
