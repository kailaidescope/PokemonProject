using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDisplay : MonoBehaviour
{
    private float time;
    public UnityEngine.UI.Text text1;
    public UnityEngine.UI.Text text2;

    // Start is called before the first frame update
    void Start()
    {
        time = Timer.finalTime;
        text1.text = "You finished in " + time + " seconds!";
        text2.text = "You finished in " + time + " seconds!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
