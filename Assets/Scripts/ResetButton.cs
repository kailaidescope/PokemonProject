using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public string scene;

    public void loadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
