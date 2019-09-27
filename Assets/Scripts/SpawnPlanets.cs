using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanets : MonoBehaviour
{

    public int numSpawned;
    public GameObject planet;

    // Start is called before the first frame update
    void Start()
    {
        while(numSpawned > 0)
        {
            Instantiate(planet);
            numSpawned--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
