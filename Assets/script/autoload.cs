using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class autoload : MonoBehaviour
{
    public float counttime;
    void Start()
    {
        counttime = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        counttime -= Time.deltaTime;
        if (counttime < 0)
        {
            SceneManager.LoadScene(7);
        }
    }
}
