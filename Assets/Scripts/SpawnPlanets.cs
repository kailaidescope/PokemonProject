using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanets : MonoBehaviour
{

    public static int numSpawned = 1;
    private int i = numSpawned;
    public GameObject planet;

    // Start is called before the first frame update
    void Start()
    {
        while(i > 0)
        {
            Instantiate(planet);
            i--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
