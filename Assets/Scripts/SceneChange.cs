using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ScoreBoardScene()
    {
        SceneManager.LoadScene("score_board");

    }
    public void gift_chaeyeonScene()
    {
        SceneManager.LoadScene("gift_chaeyeon");

    }
}