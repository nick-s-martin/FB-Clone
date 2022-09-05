using UnityEngine;

namespace Scripts.Environment
{
    public class Ground : MonoBehaviour
    {
        [SerializeField] Transform _transform;

        private void Update()
        {
        if (_transform.position.x < -4.5)
            {
                _transform.position += new Vector3(9, 0, 0);
            }
        }
    }

}
