using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField] int _PlayerScore;    
    [SerializeField] TextMeshProUGUI _ScoreText;
    [SerializeField] TextMeshProUGUI _GameOverScoreText;

    [SerializeField] private GameObject _GameOverPannel;
    [SerializeField] private GameObject _MenuPannel;
    [SerializeField] private AudioClip _backgroundMusic;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        Time.timeScale = 0;
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = _backgroundMusic;
        _audioSource.loop = true;
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
        _audioSource.Pause();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        _MenuPannel.SetActive(false);
        _audioSource.Play();

    }

    private void DisplayGameOverScore()
    {
        if (_GameOverScoreText != null)
        {
            _GameOverScoreText.text = "Score: " + _PlayerScore.ToString();
        }
    }
}