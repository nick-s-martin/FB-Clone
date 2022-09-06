using Scripts.Scoring;
using UnityEngine;
using UnityEngine.EventSystems;
using Scripts.GameManager;

namespace Scripts.Player
{
	public class Bird : MonoBehaviour
	{
		[SerializeField] Rigidbody2D _rigidbody2D;
		[SerializeField] private float _flapForce = 200f;
		[SerializeField] GameObject Score;

		public void PauseBird()
		{
			_rigidbody2D.isKinematic = true;
		}

		public void ResumeBird()
		{
            _rigidbody2D.isKinematic = false;
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
		}

		private void OnCollisionEnter2D(Collision2D collisionInfo)
		{
			if (collisionInfo.collider.tag == "Environment")
			{
                _flapForce = 0f;
                FindObjectOfType<Environment.Environment>().PauseEnvironment();
            }
			
		}

		private void OnTriggerEnter2D(Collider2D collisionInfo)
		{
            if (collisionInfo.tag == "Environment")
            {
                _flapForce = 0f;
                FindObjectOfType<Environment.Environment>().PauseEnvironment();
            }

            if (collisionInfo.tag == "Goal")
            {
				FindObjectOfType<Score>().updateScore();
            }
        }
    }
}