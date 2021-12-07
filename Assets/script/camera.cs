using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector2 velocity;
    public float Y;
    public float X;

    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, X);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, Y);

        transform.position = new Vector3(posX+5.5f, posY+3f, transform.position.z);
    }

}
