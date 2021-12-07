using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVmanager : MonoBehaviour
{
    public GameObject checkpoint;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        
    }

    public void Respawn()
    {
        Debug.Log("Player respawn");
        player.transform.position = checkpoint.transform.position;
    }
}
