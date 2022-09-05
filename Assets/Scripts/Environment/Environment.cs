using UnityEngine;

namespace Scripts.Environment
{
    public class Environment : MonoBehaviour
    {
        [SerializeField] Transform _transform;
        [SerializeField] private float _velocity = 5f;

        private void Update()
        {
            _transform.position -= transform.right * Time.deltaTime * _velocity;
        }

        public void Stop()
        {
            _velocity = 0f;
        }
    }
}