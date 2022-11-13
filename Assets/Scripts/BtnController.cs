using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour
{
    public Button btn1, btn2;

    void Start()
    {
        btn1.onClick.AddListener(redo);
        btn2.onClick.AddListener(undo);


        void redo()
        {
            GameManager.instance.life = 3;
            GameManager.instance.score = 0;
            SceneManager.LoadScene("stage1");   
        }
        void undo()
        {
            GameManager.instance.life = 3;
            GameManager.instance.score = 0;
            SceneManager.LoadScene("StartScene");
        }
    
    }
}
