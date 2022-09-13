using System;
using UnityEngine;

namespace Scripts.Player
{
    public class Score : MonoBehaviour
    {
        private int _score;
        private int _highscore;
        public event Action<int> OnScoreUpdated;
        public event Action<int> OnHighscoreUpdated;

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

            if (collisionInfo.tag == "Environment")
            {
                updateHighscore();
            }
        }


        private void OnCollisionEnter2D(Collision2D collisionInfo)
        {
            if (collisionInfo.collider.tag == "Environment")
            {
                updateHighscore();
            }
        }

        public void updateScore()
        {
            _score++;
            OnScoreUpdated?.Invoke(_score);
        }


        private void updateHighscore()
        {
            if (_highscore < _score)
            {
                _highscore = _score;
                PlayerPrefs.SetInt("Highscore", _highscore);
                OnHighscoreUpdated?.Invoke(_highscore);
            }
        }
    }
}

