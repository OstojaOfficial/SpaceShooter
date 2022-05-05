using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static void ChangeSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
