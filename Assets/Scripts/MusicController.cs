using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
        source.volume = 0.1f;
        source.clip = clip1;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("1"))
        {
            source.clip = clip1;
            source.Play();
        }
        if (Input.GetKeyDown("2"))
        {
            source.clip = clip2;
            source.Play();
        }
        if (Input.GetKeyDown("3"))
        {
            source.clip = clip3;
            source.Play();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            source.clip = clip3;
            source.Play();
        }
        if (Input.GetKeyDown("4"))
        {
            source.clip = clip4;
            source.loop = false;
            source.Play();
        }*/
    }

    public void Clip1()
    {
        source.clip = clip1;
        source.Play();
    }

    public void Clip2()
    {
        source.clip = clip2;
        source.Play();
    }

    public void Clip3()
    {
        source.clip = clip3;
        source.Play();
    }

    public void Clip4()
    {
        source.clip = clip4;
        source.Play();
    }
}
