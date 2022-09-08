using Scripts.Obstacles;
using UnityEngine;

public class BirdAngle : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] Environment environment;

    private float _angle = 0f;

    private void Update()
    {
        if (_rigidbody2D.position.y > 5)
        {
            _rigidbody2D.velocity = Vector2.zero;
        }

        if (_rigidbody2D.velocity.y >= 0)
        {
            _angle = 0;
        }
        else
        {
            _angle = Mathf.Atan2(_rigidbody2D.velocity.y, environment._velocity) * Mathf.Rad2Deg;
        }

        _rigidbody2D.SetRotation(_angle);
    }
}
