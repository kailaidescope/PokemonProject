using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCounter : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<UnityEngine.UI.Text>();
        text.text = PipeController.numPipes + " / " + SpawnPlanets.numSpawned + " - Parts Collected";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PipeController.numPipes + " / " + SpawnPlanets.numSpawned + " - Parts Collected";
    }
}
