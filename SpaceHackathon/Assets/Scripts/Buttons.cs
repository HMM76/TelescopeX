using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject home;    

    public void Home()
    {
        SceneManager.LoadScene("Modes");
        Time.timeScale = 1f;
    }

    
}
