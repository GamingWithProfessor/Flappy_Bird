using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField] int _PlayerScore;    
    [SerializeField] TextMeshProUGUI _ScoreText;

    [SerializeField] GameObject _GameOverPannel;

    public void addScore(int scoreToAdd)
    {
        _PlayerScore = _PlayerScore + scoreToAdd;
        _ScoreText.text = _PlayerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        _GameOverPannel.SetActive(true);
    }
}