using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipParts : MonoBehaviour
{
    private Canvas canvas;
    private UnityEngine.UI.Text text;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponentInChildren<Canvas>();
        text = GetComponentInChildren<UnityEngine.UI.Text>();
        text.text = "Needs Parts!";
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
