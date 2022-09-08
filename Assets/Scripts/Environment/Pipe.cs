using UnityEngine;

namespace Scripts.Obstacles
{
    public class Pipe : MonoBehaviour
    {
        [SerializeField] Transform _transform;
        private int _newHeight;

        private void Start()
        {
            _newHeight = Random.Range(-3, 3);
            _transform.position += new Vector3(0, _newHeight, 0);
        }

        private void Update()
        {
            if (_transform.position.x < -6)
            {
                _newHeight = Random.Range(-3, 3);
                _transform.position = new Vector3(6, _newHeight, 0);
            }
        }

        
    }
}

