using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gomain : MonoBehaviour
{
    public void mainmenu()
    {
        Debug.Log("main");
        SceneManager.LoadScene(0);
    }
}
