using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public LVmanager lVmanager;
    public int deathcount;
    void Start()
    {
        deathcount = PlayerPrefs.GetInt("Death");
        lVmanager = FindObjectOfType<LVmanager>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "TEST_PLAYER")
        {
            lVmanager.Respawn();
            deathcount += 1;
            PlayerPrefs.SetInt("Death", deathcount);
        }
    }
}
