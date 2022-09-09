using Scripts.Player;
using Scripts.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Scripts.Obstacles;

namespace Scripts.GameManagement
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        [SerializeField] Bird bird;
        [SerializeField] Environment environment;
        [SerializeField] ReadyMenu readyMenu;
        [SerializeField] PauseMenu pauseMenu;
        [SerializeField] GameOver gameOver;

        public bool gameHasStarted = false;
        public bool gameIsPlaying = false;


        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        //Ready Game
        private void OnLevelWasLoaded(int level)
        {
            if (SceneManager.GetActiveScene().name == "Game Scene")
            {
                bird.PauseBird();
                environment.PauseEnvironment();
                readyMenu.OpenMenu();
                gameHasStarted = false;
            }
        }

        //Start Game
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
                    readyMenu.CloseMenu();
                    gameHasStarted = true;
                }
            }
        }

        public void ResumeGame()
        {
            bird.ResumeBird();
            environment.ResumeEnvironment();
            pauseMenu.CloseMenu();
            gameIsPlaying = true;
        }

        public void RestartGame()
        {
            SceneManager.LoadScene("Game Scene");
        }

        public void PauseGame()
        {
            if (gameIsPlaying == true)
            {
                bird.PauseBird();
                environment.PauseEnvironment();
                pauseMenu.OpenMenu();
            }
        }

        public void Death()
        {
            bird.DeadBird();
            environment.PauseEnvironment();
            gameOver.OpenMenu();
            gameIsPlaying = false;
        }
    }
}