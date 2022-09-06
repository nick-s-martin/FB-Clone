using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Scripts.Player;

public class Score : MonoBehaviour
{
    public TMP_Text textDisplay;
    Bird _scoreText;

    private void Update()
    {
        textDisplay.text = _scoreText.ToString();
    }
}
