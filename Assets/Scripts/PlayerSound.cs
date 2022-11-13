using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSound : MonoBehaviour
{
    
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


    public void Playaudio()
    {
        audioSource.Play();
    }
}
