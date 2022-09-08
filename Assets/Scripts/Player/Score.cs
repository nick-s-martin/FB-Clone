using System;
using UnityEngine;

namespace Scripts.Player
{
    public class Score : MonoBehaviour
    {
        private int _score;
        public event Action<int> OnScoreUpdated;

        public void Start()
        {
            _score = 0;
        }

        private void OnTriggerEnter2D(Collider2D collisionInfo)
        {
            if (collisionInfo.tag == "Goal")
            {
                updateScore();
            }
        }

        public void updateScore()
        {
            _score++;
            OnScoreUpdated?.Invoke(_score);
        }
    }
}

