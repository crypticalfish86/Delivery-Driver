using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    /*
        OnCollisionEnter2D is a method that executes
        when the object this script is attached to
        collides with something else

        other represents information about the object that 
        this object has bumped into
    */
    public void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("You've hit an object");
    }
}
