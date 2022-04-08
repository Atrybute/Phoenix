using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartGm()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGm()
    {
        Application.Quit();
    }
    public void Quit2Menu()
    {
        SceneManager.LoadScene(0);
    }

}
