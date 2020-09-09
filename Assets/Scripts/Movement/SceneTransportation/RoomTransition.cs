using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class RoomTransition : MonoBehaviour
{
    [SerializeField] private string _sceneTarget;
    [SerializeField] private Vector2 _exitPoint;
    private bool _isLocked = false;
    // Start is called before the first frame update

    private void Awake()
    {
        if(_sceneTarget == null)
        {
            Debug.LogError("This scene does not exist.");
            _isLocked = true;
        }   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ping");
            TransferScene(collision.gameObject);
        }
    }
    public void TransferScene(GameObject player)
    {
        if (!_isLocked)
        {
            DontDestroyOnLoad(player);
            SceneManager.LoadScene(_sceneTarget);
            
        }
    }
}
