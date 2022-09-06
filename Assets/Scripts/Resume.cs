using Scripts.GameManager;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public void ResumeGame()
    {
        FindObjectOfType<GameManager>().ResumeGame();
    }
}
