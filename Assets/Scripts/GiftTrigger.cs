using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GiftTrigger : MonoBehaviour
{
    public string transferMapName;
    public GameObject character;
    public TextMeshProUGUI score_text;
    public GameObject sound_sc;
    public int score; //red = 1, white = 10
    //GameObject player = GameManager.instance.player;
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
        {
            score_text.GetComponent<IncreaseScore>().AddScore(score);
            sound_sc.GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);    
        }
        if(gameObject.name == "BigGiftPrefab" && collision.gameObject == character)
        {
            SceneManager.LoadScene(transferMapName);
        }

    }
}
