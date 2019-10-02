using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public static int numPipes;
    public AudioSource source;

    private void Start()
    {
        numPipes = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        numPipes++;
        source.Play();
        gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
