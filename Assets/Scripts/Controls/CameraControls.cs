using UnityEngine;

namespace TLY.Controls
{
    public class CameraControls:MonoBehaviour
    {
        Transform _target;

        private void Start()
        {
            if(_target == null)
            {
                _target = GameObject.FindGameObjectWithTag("Player").transform;
            }    
        }
        private void LateUpdate()
        {
                transform.position = new Vector3(_target.position.x, _target.position.y, transform.position.z);
            
        }
    }
}
