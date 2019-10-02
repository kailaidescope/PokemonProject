using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShipParts : MonoBehaviour
{
    public static bool finishedGame;
    public Collider player;

    private Canvas canvas;
    private UnityEngine.UI.Text text;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponentInChildren<Canvas>();
        text = GetComponentInChildren<UnityEngine.UI.Text>();
        text.text = "Needs Parts!";
        finishedGame = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if(PipeController.numPipes == SpawnPlanets.numSpawned && other.Equals(player))
        {
            finishedGame = true;
            SceneManager.LoadScene("VictoryScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PipeController.numPipes == SpawnPlanets.numSpawned)
        {
            text.text = "Ready to Launch!";
        }
    }
}
