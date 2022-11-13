using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    public GameObject Paper;
    public GameObject Tap;
    public GameObject FirstText;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            count++;
        if (count == 1)
        {
            Tap.SetActive(false);
            Paper.SetActive(true);
            FirstText.SetActive(true);

        }
        // 10회 누르면 씬 전환
        if (count >= 10)
            SceneManager.LoadScene(1);

    }

}
