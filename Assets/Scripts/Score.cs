using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    
    private int _score = 0;
    
    public void IncreaseScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
    
}
