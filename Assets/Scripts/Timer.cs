using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public UnityEngine.UI.Text text;
    public static float time;
    public static float finalTime;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        text.text = "Time - " + time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        text.text = "Time - " + time;
    }

    private void OnDestroy()
    {
        finalTime = time;
    }
}
