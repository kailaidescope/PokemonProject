using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float strength;
    public float maxDist;

    private Transform t;
    private GameObject player;
    private Vector3 forceDirection;
    private bool grounded;

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        t = player.transform;
        forceDirection = transform.position - t.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(t.position, transform.position) < maxDist && grounded)
        {
            forceDirection = transform.position - t.position;
            t.parent = transform;
            player.GetComponent<Rigidbody>().AddForce(forceDirection * strength, ForceMode.Acceleration);
        }
        else if (Vector3.Distance(t.position, transform.position) < maxDist && !grounded)
        {
            forceDirection = transform.position - t.position;
            t.parent = null;
            player.GetComponent<Rigidbody>().AddForce(forceDirection * strength, ForceMode.Acceleration);
        }
        else
        {
            t.parent = null;
        }

    }
}
