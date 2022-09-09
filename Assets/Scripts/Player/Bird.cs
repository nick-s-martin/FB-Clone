using Scripts.GameManagement;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Scripts.Player
{
	public class Bird : MonoBehaviour
	{
		[SerializeField] Rigidbody2D _rigidbody2D;
		[SerializeField] private float _flapForce = 8f;
		[SerializeField] GameManager gameManager;

		private bool flying = false;

		public void PauseBird()
		{
			flying = false;
			_rigidbody2D.simulated = false;
		}

		public void ResumeBird()
		{
			flying = true;
            _rigidbody2D.simulated = true;
        }

		public void DeadBird()
		{
			flying = false;
        }

		private void Update()
		{
			if (flying == true)
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
            }

			if (_rigidbody2D.position.y > 5)
			{
				_rigidbody2D.velocity = Vector2.zero;
			}
        }

		private void OnCollisionEnter2D(Collision2D collisionInfo)
		{
			if (collisionInfo.collider.tag == "Environment")
			{
                gameManager.Death();
            }
			
		}

		private void OnTriggerEnter2D(Collider2D collisionInfo)
		{
            if (collisionInfo.tag == "Environment")
            {
                gameManager.Death();
            }
        }
    }
}