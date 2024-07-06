using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*Rotate our car on the (x, y, z) axis (at start)*/
        transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        /*Every frame rotate car 45 degrees
        the f at the end of 0.1f is to tell unity its a float*/
        transform.Rotate(0, 0, 0.1f);
    }
}
