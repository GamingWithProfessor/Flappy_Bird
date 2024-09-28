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
    [SerializeField] TextMeshProUGUI _GameOverScoreText;

    [SerializeField] GameObject _GameOverPannel;
    [SerializeField] GameObject _MenuPannel;

    private void Start()
    {
        Time.timeScale = 0;
    }

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
        DisplayGameOverScore();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        _MenuPannel.SetActive(false);
    }

    private void DisplayGameOverScore()
    {
        if (_GameOverScoreText != null)
        {
            _GameOverScoreText.text = "Score: " + _PlayerScore.ToString();
        }
    }
}