using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPlanet : MonoBehaviour
{
    public float rotationSpeed;
    private GameObject obj;
    private Transform t;
    private static int numInstances = 0;

    // Start is called before the first frame update
    void Start()
    {
        numInstances++;
        obj = new GameObject("obj"+numInstances);
        t = obj.transform;
        t.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.parent = t;
        t.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
