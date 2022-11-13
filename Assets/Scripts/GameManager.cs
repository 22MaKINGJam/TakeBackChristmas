using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance;

    public int score;
    public GameObject player;
    public int life = 3;
    public GameObject Gameover;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

   


    // Update is called once per frame
    void Update()
    {

    }

   
    
}

