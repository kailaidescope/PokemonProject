using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public Transform gravSource;
    public float strength;
    private Vector3 forceDirection;
    public float maxDist;
    private bool grounded;

    private void OnCollisionEnter(Collision collision)
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
        forceDirection = gravSource.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gravSource.position, transform.position) < maxDist && grounded)
        {
            forceDirection = gravSource.position - transform.position;
            transform.parent = gravSource;
            gameObject.GetComponent<Rigidbody>().AddForce(forceDirection * strength, ForceMode.Acceleration);
        }
        if (Vector3.Distance(gravSource.position, transform.position) < maxDist && !grounded)
        {
            forceDirection = gravSource.position - transform.position;
            transform.parent = null;
            gameObject.GetComponent<Rigidbody>().AddForce(forceDirection * strength, ForceMode.Acceleration);
        }

    }
}
