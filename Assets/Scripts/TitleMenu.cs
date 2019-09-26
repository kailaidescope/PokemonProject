using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public string scene;

    public void Quit()
    {
        Application.Quit();
    }

    public void loadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
