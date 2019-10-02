using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;
    public AudioSource source;
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

    public void Resume()
    {
        source.GetComponent<MusicController>().Clip1();
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        source.GetComponent<MusicController>().Clip3();
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    private void OnDestroy()
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
