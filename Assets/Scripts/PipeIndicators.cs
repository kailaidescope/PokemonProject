using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIndicators : MonoBehaviour
{
    private UnityEngine.UI.RawImage img;
    public GameObject pipes;

    // Start is called before the first frame update
    void Start()
    {
        img = gameObject.GetComponentInChildren<UnityEngine.UI.RawImage>();
        img.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pipes.activeSelf == false)
        {
            img.enabled = true;
        }
    }
}
