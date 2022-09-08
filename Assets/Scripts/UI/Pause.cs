using Scripts.GameManagement;
using UnityEngine;

namespace Scripts.UI
{
    public class Pause : MonoBehaviour
    {
        [SerializeField] GameManager gameManager;

        public void PauseGame()
        {
            gameManager.PauseGame();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseGame();
            }
        }
    }
}
