using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    [SerializeField] private int _PlayerScore;
    [SerializeField] private TextMeshProUGUI _ScoreText;

    public void addScore(int score)
    {
        _PlayerScore = _PlayerScore + 1;
        _ScoreText.text = _PlayerScore.ToString();
    }
}