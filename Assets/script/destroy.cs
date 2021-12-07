using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    public float counttime1;
    public float counttime2;
    public GameObject s_1;
    public GameObject s_2;
    public GameObject s_3;
    public GameObject s_4;
    public bool next;
    void Start()
    {
        counttime1 = 5f;
        counttime2 = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        counttime1 -= Time.deltaTime;
        if (counttime1 < 0)
        {
            trigger();
            counttime2 -= Time.deltaTime;
            counttime1 = -0.1f;
        }
        if (counttime2 < 0)
        {
            s_3.transform.position = s_4.transform.position;
            next = true;
        }
        if (counttime2 <0 && next==true&&(Input.GetKeyDown(KeyCode.Space)))
        {
            SceneManager.LoadScene(2);
        }
    }
    void trigger()
    {
            s_2.transform.position = s_1.transform.position;        
    }
    
}
