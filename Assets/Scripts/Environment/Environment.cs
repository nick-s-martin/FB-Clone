using UnityEngine;

namespace Scripts.Obstacles
{
    public class Environment : MonoBehaviour
    {
        [SerializeField] Transform _transform;
        [SerializeField] public float _velocity;

        private bool moving = true;

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