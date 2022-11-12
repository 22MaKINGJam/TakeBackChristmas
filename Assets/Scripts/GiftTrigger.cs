using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GiftTrigger : MonoBehaviour
{
    public GameObject character;
    public TextMeshProUGUI score_text;
    public int score; //pink = 1, green = 10
    // Start is called before the first frame update
    void Start()
    {
        score_text = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "pinkGift")
        //    score_text.GetComponent<IncreaseScore>().AddScore(1); //pink gift socre = 1
        //else if(collision.gameObject.tag == "greenGift")
        //    score_text.GetComponent<IncreaseScore>().AddScore(10); //green gift socre = 10
        if(collision.gameObject.name == "Character")
            score_text.GetComponent<IncreaseScore>().AddScore(score);
        gameObject.SetActive(false);
    }
}
