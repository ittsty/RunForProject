using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class summary : MonoBehaviour
{
    public Text textbox;
    public Text textbox2;
    public Text textbox3;
    public float timer;
    public int deathcount;
    public bool min_in_time;
    public char grade;
    void Start()
    {
        deathcount = PlayerPrefs.GetInt("Death");
        timer = PlayerPrefs.GetFloat("Timeset");

        int min = (int)timer / 60;
        int sec = (int)timer % 60;
        timer += Time.deltaTime;
        textbox.text = string.Format("{0:00}:{1:00}", min, sec);
        textbox2.text = deathcount.ToString();

        if (min < 36)
        {
            min_in_time = true;
        }
        else
        {
            min_in_time = false;
        }

        switch (min_in_time)
        {
            case true :
                if (min <21)
                {
                    grade = 'A';
                }
                else if (min > 20 && min < 26)
                {
                    grade = 'B';
                }
                else if (min > 25 && min < 31)
                {
                    grade = 'C';
                }
                else if (min > 30  && min < 36)
                {
                    grade = 'D';
                }
                break;
            case false:
                grade = 'F';
                break;
        }
        textbox3.text = string.Format("{0}",grade);
    }

}
