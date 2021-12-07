using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public LVmanager lVmanager;
    public GameObject sigh_G;
    public GameObject sigh_h;
    void Start()
    {
        lVmanager = FindObjectOfType<LVmanager>();
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "TEST_PLAYER")
        {
            lVmanager.checkpoint = gameObject;
            sigh_G.transform.position = sigh_h.transform.position;

        }
    }
}

