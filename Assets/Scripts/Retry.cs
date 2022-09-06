using UnityEngine;
using Scripts.GameManager;

public class Retry : MonoBehaviour
{
    public void RestartGame()
    {
        FindObjectOfType<GameManager>().RestartGame();
    }
}
