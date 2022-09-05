using UnityEngine;
using Scripts.Environment;

namespace Scripts.Player
{
	public class Bird : MonoBehaviour
	{
		[SerializeField] Rigidbody2D _rigidbody2D;
		[SerializeField] private float _flapForce = 200f;

		private void Update()
		{
			if (Input.anyKeyDown)
			{
				_rigidbody2D.AddForce(Vector2.up * _flapForce, ForceMode2D.Impulse);
			}
		}

		private void OnCollisionEnter2D(Collision2D collisionInfo)
		{
			if (collisionInfo.collider.tag == "Environment")
			{
                _flapForce = 0f;
                FindObjectOfType<Environment.Environment>().Stop();
            }
			
		}

		private void OnTriggerEnter2D(Collider2D collisionInfo)
		{
            if (collisionInfo.tag == "Environment")
            {
                _flapForce = 0f;
                FindObjectOfType<Environment.Environment>().Stop();
            }
        }
	}
}