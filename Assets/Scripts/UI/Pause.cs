using Scripts.GameManager;
using UnityEngine;

namespace Scripts.UI
{
    public class Pause : MonoBehaviour
    {
        public void PauseGame()
        {
            FindObjectOfType<GameManager.GameManager>().PauseGame();
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
