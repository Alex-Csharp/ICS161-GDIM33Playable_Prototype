using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMEOVER1 : MonoBehaviour
{
    public GameObject GameOverMenu;



    public void Restart()
    {
        SceneManager.LoadScene(0);

    }

    public void Quit()
    {
        Application.Quit();

    }
}