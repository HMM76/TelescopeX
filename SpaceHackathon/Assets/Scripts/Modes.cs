using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Modes : MonoBehaviour
{
    public GameObject mode1;
    public GameObject mode2;
    public GameObject home;

    public void Mode1()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
    public void Mode2()
    {
        SceneManager.LoadScene("Solar System");
        Time.timeScale = 1;
    }

     public void Home()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
    }
}
