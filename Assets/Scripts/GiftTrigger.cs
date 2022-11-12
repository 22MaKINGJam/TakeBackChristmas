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
        if(collision.gameObject == character)
            score_text.GetComponent<IncreaseScore>().AddScore(score);
        gameObject.SetActive(false);
    }
}
