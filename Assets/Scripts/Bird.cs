using UnityEngine;
using UnityEngine.EventSystems;
using Scripts.Environment;

namespace Scripts.Player
{
	public class Bird : MonoBehaviour
	{
		[SerializeField] Rigidbody2D _rigidbody2D;
		[SerializeField] private float _flapForce = 200f;

		public float _score = 0f;
		public string _scoreText;

		private void Update()
		{
            string _scoreText = _score.ToString();

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

            if (collisionInfo.tag == "Goal")
            {
				_score = _score + 1;
            }
        }
    }
}