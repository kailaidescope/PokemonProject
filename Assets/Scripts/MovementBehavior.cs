using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementBehavior : MonoBehaviour
{
    public float RotationSpeed;
    public float YawSpeed;
    public float flySpeed;
    public float jumpSpeed;
    public Transform center;
    public int numPipes = 0;

    private Camera cam;
    private bool grounded;
    private Rigidbody rb;


    private void Start()
    {
        cam = gameObject.GetComponentInChildren<Camera>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

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
        center.localRotation = Quaternion.Euler(0f, -8.884001f, 0f);
        grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.isPaused == false)
        {
            if (!grounded)
            {
                rb.angularVelocity = new Vector3(0f, 0f, 0f);
            }

            transform.Rotate(0f, Input.GetAxis("Mouse X") * RotationSpeed, 0f);
            if (grounded)
            {
                center.Rotate(0f, -Input.GetAxis("Mouse Y") * RotationSpeed, 0f);
            }
            if (!grounded)
            {
                transform.Rotate(-Input.GetAxis("Mouse Y") * RotationSpeed, 0f, 0f);
            }
            if (Input.GetKey("q") && !grounded)
            {
                transform.Rotate(0f, 0f, YawSpeed);
            }
            if (Input.GetKey("e") && !grounded)
            {
                transform.Rotate(0f, 0f, -YawSpeed);
            }
            if (Input.GetKey("w"))
            {
                transform.Translate(0f, 0f, 0.1f);
            }
            if (Input.GetKeyDown("w") && !grounded)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.forward * flySpeed, ForceMode.Impulse);
            }
            if (Input.GetKey("s"))
            {
                transform.Translate(0f, 0f, -0.1f);
            }
            if (Input.GetKeyDown("s") && !grounded)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.back * flySpeed, ForceMode.Impulse);
            }
            if (Input.GetKey("a"))
            {
                transform.Translate(-0.1f, 0f, 0f);
            }
            if (Input.GetKey("d"))
            {
                transform.Translate(0.1f, 0f, 0f);
            }
            if (Input.GetKeyDown("space") && grounded)
            {
                transform.parent = null;
                gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.up * jumpSpeed, ForceMode.Impulse);
            }
            if (Input.GetKeyDown("space") && !grounded)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.up * jumpSpeed, ForceMode.Impulse);
            }
            if (Input.GetKeyDown("z") && grounded)
            {
                transform.parent = null;
                gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.down * jumpSpeed, ForceMode.Impulse);
            }

            if (Input.GetKeyDown("z") && !grounded)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.down * flySpeed, ForceMode.Impulse);
            }
            if (Input.mouseScrollDelta.y > 0)
            {
                cam.transform.Translate(0f, 0f, 0.5f);
            }
            if (Input.mouseScrollDelta.y < 0)
            {
                cam.transform.Translate(0f, 0f, -0.5f);
            }
        }
    }
}
