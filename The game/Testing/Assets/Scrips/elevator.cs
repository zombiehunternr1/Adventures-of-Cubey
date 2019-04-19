using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    //Creates a public transform called startElevator
    public Transform startElevator;
    //Creates a public transform called endElevator
    public Transform endElevator;
    //Creates a public boolean called up
    public bool up;
    //Creates a public float called smoothTime and give it a value of 0.3F
    public float smoothTime = 0.3F;
    //Creates a private vector3 called velocity and sets the velocity to 0
    private Vector3 velocity = Vector3.zero;

    //This function sets the boolean up to true
    public void moveUp()
    {
        up = true;
    }

    //This function sets the boolean up to false
    public void moveDown()
    {
        up = false;
    }


    // Update is called once per frame
    void Update()
    {
        //Creates a transform object called Target
        Transform Target;   
        //Checks if the boolean up is true
        if (up)
        {
            //Sets the target to endElevator
            Target = endElevator;
        }
        else
        {
            //Sets the target to startElevator
            Target = startElevator;
        }
        // Smoothly moves the elevator op and down to the start and end position
        transform.position = Vector3.SmoothDamp(transform.position, Target.position, ref velocity, smoothTime);
        
    }   
}
