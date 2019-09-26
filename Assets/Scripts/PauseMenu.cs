using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;

    public GameObject menuUI;

    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    private void OnDestroy()
    {
        Resume();
    }

    public void unpause()
    {
        Resume();
    }

    public void Home()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
