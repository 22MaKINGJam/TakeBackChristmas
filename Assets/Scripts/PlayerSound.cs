using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSound : MonoBehaviour
{

    public AudioClip audioJump;
    public AudioClip audioJumpTwice;
    public AudioClip audioDamage;
    public AudioClip audioScore;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
    	this.audioSource = GetComponent<AudioSource>();
    }

public void PlaySound(string action)
    {
        switch (action)
        {
            case "jump":
                audioSource.clip = audioJump;
                break;
            case "jumpTwice":
                audioSource.clip = audioJumpTwice;
                break;
            case "damage":
                audioSource.clip = audioDamage;
                break;
            case "getscore":
                audioSource.clip = audioScore;
                break;
            default:
                break;

        }
        audioSource.Play();
    }
}
