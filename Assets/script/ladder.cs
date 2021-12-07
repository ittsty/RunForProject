using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    private PLAYER player;
    void Start()
    {
        player = FindObjectOfType<PLAYER>();
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Player")
        {
            player.ladder = true;
            player.con = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.ladder = false;
        }
    }
}
