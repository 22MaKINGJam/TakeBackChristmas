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
    public string scoreload(string SBscore_){
        if(PlayerPrefs.GetInt(SBscore_)!=0)
                return  PlayerPrefs.GetInt(SBscore_).ToString();
                else return "";
    }
    public void loadScore()
    {
        score0.text = scoreload("SBscore0");
        score1.text = scoreload("SBscore1");
        score2.text = scoreload("SBscore2");
        score3.text = scoreload("SBscore3");
        score4.text = scoreload("SBscore4");
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
