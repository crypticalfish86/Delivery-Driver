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
        this object has collided with
    */
    public void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("You've hit an object");
    }

    /*
        OnTriggerEnter2D is a method that executes 
        when the object this script is attached to
        overlaps with a "trigger" object

        other represents information about the object 
        that this object has collided with
    */
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("You've passed over the trigger");
    }
}
