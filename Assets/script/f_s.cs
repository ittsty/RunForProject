using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class f_s : MonoBehaviour
{
    public float timer;
    void Start()
    {
        timer = PlayerPrefs.GetFloat("Timeset");
    }
    void Update()
    {
        timer = PlayerPrefs.GetFloat("Timeset");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
      int min = (int)timer / 60;
        if (col.tag == "Player")
        {
           if(min < 36)
           {
                    SceneManager.LoadScene(5);
           }
           else
           {
                    SceneManager.LoadScene(6);
           }
        }
    }
}
