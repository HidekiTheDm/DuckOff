using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadSceneNivel1()
    {
        Debug.Log("Aqui");
        SceneManager.LoadScene("Lvl1");
    }
}