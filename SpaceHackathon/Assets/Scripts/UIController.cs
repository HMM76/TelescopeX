using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject AboutPanel;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void AboutButton()
    {
        AboutPanel.SetActive(true);
    }

    public void AboutQuitButton()
    {
        AboutPanel.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
