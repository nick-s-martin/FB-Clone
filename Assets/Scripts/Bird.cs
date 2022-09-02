using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Player
{
	public class Bird : MonoBehaviour
	{
		[SerializeField]
		Rigidbody2D _rigidbody2D;

		[SerializeField]
		float _flapForce = 200f;

		private void Update()
		{
			if (Input.anyKeyDown)
			{
				_rigidbody2D.AddForce(Vector2.up * _flapForce, ForceMode2D.Impulse);
			}
		}

	}
}