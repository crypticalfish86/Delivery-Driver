using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    //our variable declarations must be inside the class
    [SerializeField] float steerSpeed = 1f; //the speed of our steering
    [SerializeField] float moveSpeed = 0.01f; //the speed our car is moving (backwards and forwards)

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
            every frame calculate the amount the car is steering
            It is then mutiplied by steerSpeed so we are able to
            change how fast we turn
        */
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;

        /*
            Every frame calculate the speed of the car It is 
            then multiplied by moveSpeed so we are able to change
            how fast the car is moving back and forth
        */
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        
        /*Every frame rotate car on the (x, y, z) axis using inputs in unity (directions inverted)*/
        transform.Rotate(0, 0, -steerAmount);

        /*Every frame move our car forward or backwards relative to its y direction*/
        transform.Translate(0, moveAmount , 0);
    }
}
