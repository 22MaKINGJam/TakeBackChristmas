using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
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
    
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit(); // 어플리케이션 종료
    }

}