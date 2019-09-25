using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPlanet : MonoBehaviour
{
    public float rotationSpeed;
    public Transform t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.parent = t;
        t.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
