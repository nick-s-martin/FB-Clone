using UnityEngine;

namespace Scripts.Environment
{
    public class Environment : MonoBehaviour
    {
        [SerializeField] Transform _transform;
        [SerializeField] private float _velocity;

        private bool moving = false;

        private void Update()
        {
            if (moving == true)
            _transform.position -= transform.right * Time.deltaTime * _velocity;
        }

        public void ResumeEnvironment()
        {
            moving = true;
        }

        public void PauseEnvironment()
        {
            moving = false;
        }
    }
}