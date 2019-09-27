using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGen : MonoBehaviour
{

    private GameObject obj;
    private Transform t;
    private PlanetGravity planetGrav;
    private OrbitPlanet orbitPlanet;

    public Material[] materials = new Material[4];

    public Material dirt;
    public Material grass;
    public Material stone;
    public Material sand;
    public Material snow;

    private int min = 0;
    private int max = 4;

    // Start is called before the first frame update
    void Start()
    {
        //materials[0] = dirt;
        materials[1] = grass;
        materials[2] = stone;
        materials[3] = sand;
        materials[4] = snow;

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
        gameObject.GetComponent<Renderer>().material = materials[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
