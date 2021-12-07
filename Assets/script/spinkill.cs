using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinkill : MonoBehaviour
{
    public LVmanager lVmanager;
    public float speed = 1000f;
    void Start()
    {
        lVmanager = FindObjectOfType<LVmanager>();
    }

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "TEST_PLAYER")
        {
            lVmanager.Respawn();
        }
    }
}
