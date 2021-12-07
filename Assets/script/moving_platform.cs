using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platform : MonoBehaviour
{
    public GameObject platform;

    public Transform current;
    public Transform[] points;

    public float speed;

    public int pointselect;

    void Start()
    {
        randomspeed();
        current = points[pointselect];
    }

    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, current.position, Time.deltaTime * speed);
        if(platform.transform.position == current.position)
        {
            pointselect++;
            if(pointselect == points.Length)
            {
                pointselect = 0;
            }
            current = points[pointselect];
        }
    }
    public void randomspeed()
    {
        if (speed == 0)
        {
            speed = Random.Range(4, 8);
        }
    }
}
