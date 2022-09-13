using TMPro;
using UnityEngine;
using Scripts.Player;

namespace Scripts.UI
{
    public class HighscoreDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text _highscoreText;
        [SerializeField] private Score _highscore;

        private void Awake()
        {
            _highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
            _highscore.OnHighscoreUpdated += handleHighscoreUpdated;
        }

        private void handleHighscoreUpdated(int _highscore)
        {
            _highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
        }

        private void OnDestroy()
        {
            _highscore.OnScoreUpdated -= handleHighscoreUpdated;
        }
    }
}
