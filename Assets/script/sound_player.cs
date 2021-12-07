using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_player : MonoBehaviour
{
    AudioSource Sound; 
    public AudioClip backMusic;
    void Start()
    {
        Sound = GetComponent<AudioSource>();
        Sound.Play();
    }

    void Update()
    {
        
    }
}
