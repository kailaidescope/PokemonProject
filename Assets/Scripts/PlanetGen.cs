using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGen : MonoBehaviour
{

    private GameObject obj;
    private Transform t;
    private PlanetGravity planetGrav;
    private OrbitPlanet orbitPlanet;

    // Start is called before the first frame update
    void Start()
    {
        obj = new GameObject("obj1");
        t = obj.transform;
        t.position = new Vector3(0f, 0f, 0f);
        transform.parent = t;
        transform.position = new Vector3(Random.Range(60f, 300f), 0f, 0f);
        transform.localScale = Vector3.one * Random.Range(1.5f, 5f);
        t.localRotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 360f));
        transform.parent = null;
        Destroy(obj);
        transform.localRotation = Quaternion.Euler(Vector3.up * Random.Range(0f, 360f));
        planetGrav = gameObject.GetComponent<PlanetGravity>();
        planetGrav.maxDist = transform.localScale.magnitude * 6f;
        planetGrav.strength = 5f;
        orbitPlanet = gameObject.GetComponent<OrbitPlanet>();
        orbitPlanet.rotationSpeed = Random.Range(0.1f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
