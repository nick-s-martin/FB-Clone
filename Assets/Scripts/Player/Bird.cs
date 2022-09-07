using Scripts.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using Scripts.GameManager;
using Unity.VisualScripting;

namespace Scripts.Player
{
	public class Bird : MonoBehaviour
	{
		[SerializeField] Rigidbody2D _rigidbody2D;
		[SerializeField] private float _flapForce = 200f;
		private float _angle = 0f;

		public void PauseBird()
		{
			_rigidbody2D.simulated = false;
		}

		public void ResumeBird()
		{
            _rigidbody2D.simulated = true;
        }

		public void DeadBird()
		{
            _flapForce = 0f;
        }

		private void Update()
		{
            if (Input.anyKeyDown)
			{
				if (EventSystem.current.IsPointerOverGameObject())
					if (Input.GetMouseButtonDown(0))
						return;

				if (Input.GetKeyDown(KeyCode.Escape))
					return;

				_rigidbody2D.AddForce(Vector2.up * _flapForce, ForceMode2D.Impulse);
			}

			if (_rigidbody2D.position.y > 5)
			{
				_rigidbody2D.velocity = Vector2.zero;
			}

			if (_rigidbody2D.velocity.y >= 0)
			{
				_angle = 0;
			}
			else {
                _angle = Mathf.Atan2(_rigidbody2D.velocity.y, FindObjectOfType<Environment.Environment>()._velocity) * Mathf.Rad2Deg;
            }

            _rigidbody2D.SetRotation(_angle);
        }

		private void OnCollisionEnter2D(Collision2D collisionInfo)
		{
			if (collisionInfo.collider.tag == "Environment")
			{
                FindObjectOfType<GameManager.GameManager>().Death();
            }
			
		}

		private void OnTriggerEnter2D(Collider2D collisionInfo)
		{
            if (collisionInfo.tag == "Environment")
            {
                FindObjectOfType<GameManager.GameManager>().Death();
            }

            if (collisionInfo.tag == "Goal")
            {
				FindObjectOfType<Score>().updateScore();
            }
        }
    }
}