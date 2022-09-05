using UnityEngine;

namespace Scripts.Environment
{
    public class Pipe : MonoBehaviour
    {
        [SerializeField] Transform _transform;

        private void Start()
        {
            var _newHeight = Random.Range(-3, 3);
            _transform.position += new Vector3(0, _newHeight, 0);
        }

        private void Update()
        {
            if (_transform.position.x < -6)
            {
                var _newHeight = Random.Range(-3, 3);
                _transform.position = new Vector3(6, _newHeight, 0);
            }
        }

        
    }
}

