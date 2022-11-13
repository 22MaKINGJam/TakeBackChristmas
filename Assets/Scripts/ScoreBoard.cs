using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public TextMeshProUGUI score0;
    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;
    public TextMeshProUGUI score3;
    public TextMeshProUGUI score4;

    public int[] SBscore = new int[5];

    GameManager gameManager;

    public int currentScore;

    public void saveCurrentScore()
    {
        currentScore = PlayerPrefs.GetInt("currentScore");
        if (currentScore > SBscore[4])
        {
            SBscore[4] = currentScore;
        }
    }
    public void saveScore()
    {
        PlayerPrefs.SetInt("SBscore0", SBscore[0]);
        PlayerPrefs.SetInt("SBscore1", SBscore[1]);
        PlayerPrefs.SetInt("SBscore2", SBscore[2]);
        PlayerPrefs.SetInt("SBscore3", SBscore[3]);
        PlayerPrefs.SetInt("SBscore4", SBscore[4]);
        PlayerPrefs.Save();
    }
    public void loadScore()
    {
        score0.text = "1등 : " + PlayerPrefs.GetInt("SBscore0").ToString();
        score1.text = "2등 : " + PlayerPrefs.GetInt("SBscore1").ToString();
        score2.text = "3등 : " + PlayerPrefs.GetInt("SBscore2").ToString();
        score3.text = "4등 : " + PlayerPrefs.GetInt("SBscore3").ToString();
        score4.text = "5등 : " + PlayerPrefs.GetInt("SBscore4").ToString();
    }
    public void sortscore()
    {
        Array.Sort(SBscore);
        Array.Reverse(SBscore);
    }
    public void clearCurrentScore()
    {
        PlayerPrefs.SetInt("currentScore", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        sortscore();
        saveCurrentScore();
        sortscore();
        saveScore();
        loadScore();
        clearCurrentScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
