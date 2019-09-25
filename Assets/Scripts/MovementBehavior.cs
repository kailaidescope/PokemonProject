using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementBehavior : MonoBehaviour
{

    private bool grounded;
    private float flyPower = 1;
    public Image flyMeter;
    private float meterMax;
    private float meterMaxW;
    private Camera cam;
    public float RotationSpeed;
    public float flySpeed;

    private void Start()
    {
        meterMaxW = 30f;
        meterMax = 130f;
        cam = gameObject.GetComponentInChildren<Camera>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
        flyPower = 1;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

    // Update is called once per frame
    void Update()
    {

        flyMeter.rectTransform.sizeDelta = new Vector2(meterMaxW, meterMax * flyPower);

        transform.Rotate(0f, Input.GetAxis("Mouse X") * RotationSpeed, 0f);
        if (!grounded)
        {
            transform.Rotate(-Input.GetAxis("Mouse Y") * RotationSpeed, 0f, 0f);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0f,0f, 0.1f);
        }
        if (Input.GetKey("w") && !grounded)
        {
            transform.parent = null;
            gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.forward * flySpeed, ForceMode.Impulse);
            flyPower -= 0.05f;
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0f, 0f, -0.1f);
        }
        if (Input.GetKey("s") && !grounded)
        {
            transform.parent = null;
            gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.back * flySpeed, ForceMode.Impulse);
            flyPower -= 0.05f;
        }
        if (Input.GetKeyDown("space") && flyPower > 0)
        {
            transform.parent = null;
            gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.up * 10f, ForceMode.Impulse);
            flyPower -= 0.05f;
        }
        if (Input.GetKeyDown("z") && flyPower > 0)
        {
            transform.parent = null;
            gameObject.GetComponent<Rigidbody>().AddForce(transform.localRotation * Vector3.down * 10f, ForceMode.Impulse);
            flyPower -= 0.05f;
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
