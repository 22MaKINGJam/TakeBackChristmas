using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncreaseScore : MonoBehaviour
{
    public TextMeshProUGUI score_text;
    int score_sum = 0;
    // Start is called before the first frame update
    void Start()
    {
        score_text.text = ""+score_sum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        score_sum += score;
        score_text.text = "" + score_sum;
        GameManager.instance.score = score_sum;
        PlayerPrefs.SetInt("currentScore", GameManager.instance.score);
    }
}
