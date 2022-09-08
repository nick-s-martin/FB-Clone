using Scripts.GameManagement;
using UnityEngine;

namespace Scripts.UI
{
    public class Resume : MonoBehaviour
    {
        [SerializeField] GameManager gameManager;

        public void ResumeGame()
        {
            gameManager.ResumeGame();
        }
    }
}