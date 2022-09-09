using TMPro;
using UnityEngine;
using Scripts.Player;

namespace Scripts.UI
{
    public class ScoreDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private Score _score;

        private void Awake()
        {
            _score.OnScoreUpdated += handleScoreUpdated;
        }

        private void handleScoreUpdated(int _score)
        {
            _scoreText.text = _score.ToString();
        }

        private void OnDestroy()
        {
            _score.OnScoreUpdated -= handleScoreUpdated;
        }
    }
}