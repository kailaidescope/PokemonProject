﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string scene;

    public void loadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
