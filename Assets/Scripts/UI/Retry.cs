using UnityEngine;
using Scripts.GameManagement;

namespace Scripts.UI
{
    public class Retry : MonoBehaviour
    {
        [SerializeField] GameManager gameManager;

        public void RestartGame()
        {
            gameManager.RestartGame();
        }
    }
}