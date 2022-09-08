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

		private Vector2 _direction;
		private bool moving = false;

		public void PauseBird()
		{
			moving = false;
			_rigidbody2D.simulated = false;
		}

		public void ResumeBird()
		{
			moving = true;
            _rigidbody2D.simulated = true;
        }

		public void DeadBird()
		{
			moving = false;
        }

		private void Update()
		{
			if (moving == true)
			{
                if (Input.anyKeyDown)
                {
                    if (EventSystem.current.IsPointerOverGameObject())
                        if (Input.GetMouseButtonDown(0))
                            return;

                    if (Input.GetKeyDown(KeyCode.Escape))
                        return;

                    _rigidbody2D.AddForce(_direction * _flapForce, ForceMode2D.Impulse);
                }
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