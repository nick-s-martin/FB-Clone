using UnityEngine;
using Scripts.GameManager;

namespace Scripts.UI
{
    public class Retry : MonoBehaviour
    {
        public void RestartGame()
        {
            FindObjectOfType<GameManager.GameManager>().RestartGame();
        }
    }
}