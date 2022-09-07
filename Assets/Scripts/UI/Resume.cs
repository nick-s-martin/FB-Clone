using Scripts.GameManager;
using UnityEngine;

namespace Scripts.UI
{
    public class Resume : MonoBehaviour
    {
        public void ResumeGame()
        {
            FindObjectOfType<GameManager.GameManager>().ResumeGame();
        }
    }
}