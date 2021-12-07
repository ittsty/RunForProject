using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject door;
    public GameObject clear;
    public GameObject key;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "TEST_PLAYER")
        {         
            door.transform.position = clear.transform.position;
            Destroy(key);
        }
    }
}
