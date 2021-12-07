using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public string level1;
    public float Timer;
    public int deathcount;
    public void startgames()
    {
        Debug.Log("start");
        SceneManager.LoadScene(1);
        PlayerPrefs.SetFloat("Timeset", Timer);
        PlayerPrefs.SetInt("Death", deathcount);
    }
    public void Quitgame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void cradit()
    {
        SceneManager.LoadScene(8);
    }
}
