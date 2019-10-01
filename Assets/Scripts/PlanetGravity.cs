using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float strength;
    public float maxDist;

    private GameObject player;
    private Vector3 forceDirection;
    private bool grounded;

    public static int instances;

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
        player.transform.parent = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody>();
        instances++;
        //gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        player = GameObject.Find("Player");
        forceDirection = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(grounded);
        if (Vector3.Distance(transform.position, player.transform.position) < maxDist && grounded)
        {
            forceDirection = transform.position - player.transform.position;
            player.transform.parent = transform;
            player.GetComponent<Rigidbody>().AddForce(forceDirection * strength, ForceMode.Acceleration);
        }
        else if (Vector3.Distance(transform.position, player.transform.position) < maxDist && !grounded)
        {
            forceDirection = transform.position - player.transform.position;
            player.GetComponent<Rigidbody>().AddForce(forceDirection * strength, ForceMode.Acceleration);
        }
    }
}
