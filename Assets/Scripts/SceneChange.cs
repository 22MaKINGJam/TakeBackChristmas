using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public Button btn1;
    void Start()
    {

        btn1.onClick.AddListener(undo);

        void undo()
        {
            GameManager.instance.life = 3;
            GameManager.instance.score = 0;
            SceneManager.LoadScene("StartScene");
        }
    }

    public void StartSceneYes()
    {
        SceneManager.LoadScene("StartScene_Yes");

    }
    public void stage1()
    {
        SceneManager.LoadScene("stage1");

    }
    public void ScoreBoardScene()
    {
        SceneManager.LoadScene("score_board");

    }
    public void gift_chaeyeonScene()
    {
        SceneManager.LoadScene("gift_chaeyeon");

    }


}