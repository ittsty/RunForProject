using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TIMER : MonoBehaviour
{
    public float timer;
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox.text = timer.ToString("0:00.00");
    }

    // Update is called once per frame
    void Update()
    {
        int min = (int)timer / 60;
        int sec = (int)timer % 60;
        timer += Time.deltaTime;
        textbox.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}
