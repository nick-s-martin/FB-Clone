using UnityEngine;

namespace Scripts.Environment
{
    public class Environment : MonoBehaviour
    {
        [SerializeField] Transform _transform;
        [SerializeField] float _velocity = 5f;

        private void Update()
        {
            _transform.position -= transform.right * Time.deltaTime * _velocity;
        }
    }
}