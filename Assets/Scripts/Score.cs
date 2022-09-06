using TMPro;
using UnityEngine;

namespace Scripts.Scoring
{
    public class Score : MonoBehaviour
    {
        public TMP_Text _scoreText;
        public float _score = 0f;

        public void updateScore()
        {
            _score = _score + 1;
            _scoreText.text = _score.ToString();
        }
    }
}

