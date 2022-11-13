using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScene : MonoBehaviour
{
    public GameObject Paper;
    public GameObject todtjd;
    int count;
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

            Paper.SetActive(false);
            todtjd.SetActive(true);


        }
    }
}
