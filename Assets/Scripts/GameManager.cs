using Scripts.Player;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Enviro = Scripts.Environment.Environment;

namespace Scripts.GameManager
{
    public class GameManager : MonoBehaviour
    {
        public bool gameHasStarted = false;

        void Awake()
        {
            FindObjectOfType<Bird>().PauseBird();
        }

        private void Update()
        {
            if (gameHasStarted == false)
            {
                if (Input.anyKeyDown)
                {
                    if (EventSystem.current.IsPointerOverGameObject())
                        if (Input.GetMouseButtonDown(0))
                            return;

                    if (Input.GetKeyDown(KeyCode.Escape))
                        return;

                    ResumeGame();
                    gameHasStarted = true;
                }
            }
        }

        public void ResumeGame()
        {
            FindObjectOfType<Bird>().ResumeBird();
            FindObjectOfType<Enviro>().ResumeEnvironment();
        }

        public void RestartGame()
        {
            SceneManager.LoadScene("Game Scene");
            gameHasStarted = false;
        }
    }
}