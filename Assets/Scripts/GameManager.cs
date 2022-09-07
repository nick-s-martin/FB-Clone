using Scripts.Player;
using Scripts.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Enviro = Scripts.Environment.Environment;

namespace Scripts.GameManager
{
    public class GameManager : MonoBehaviour
    {
        public bool gameHasStarted = false;

        private void OnLevelWasLoaded(int level)
        {
            if (SceneManager.GetActiveScene().name == "Game Scene")
            {
                FindObjectOfType<Bird>().PauseBird();
                FindObjectOfType<Enviro>().PauseEnvironment();
                FindObjectOfType<ReadyMenu>().OpenMenu();
            }
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
                    FindObjectOfType<ReadyMenu>().CloseMenu();
                    gameHasStarted = true;
                }
            }
        }

        public void ResumeGame()
        {
            FindObjectOfType<Bird>().ResumeBird();
            FindObjectOfType<Enviro>().ResumeEnvironment();
            FindObjectOfType<PauseMenu>().CloseMenu();
        }

        public void RestartGame()
        {
            SceneManager.LoadScene("Game Scene");
            gameHasStarted = false;
        }

        public void PauseGame()
        {
            FindObjectOfType<Bird>().PauseBird();
            FindObjectOfType<Enviro>().PauseEnvironment();
            FindObjectOfType<PauseMenu>().OpenMenu();
        }

        public void Death()
        {
            FindObjectOfType<Bird>().DeadBird();
            FindObjectOfType<Enviro>().PauseEnvironment();
            FindObjectOfType<GameOver>().OpenMenu();
        }
    }
}