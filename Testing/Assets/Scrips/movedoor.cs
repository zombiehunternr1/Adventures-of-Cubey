using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    //Creates a private boolean named active and is set to false
    private bool active = false;
    //Creates a public float named speed
    public float Speed;
  
    //Creates a private float named startHeight
    private float startHeight;
    //Creates a public boolean called Up
    public bool Up;
    //Creates a public boxcollider called doorCollider
    public BoxCollider doorCollider;
    //Y coordinates the door to the targeted Y position
    private float targetY; 
    

    void Start()
    {
        //StartHeight gets the current Y position from the object
        startHeight = transform.position.y;
        //Checks if up is true
        if (Up)
        {
            //Stores the top position of the Y coordinate of the object where it's currently at
            targetY = transform.position.y + doorCollider.bounds.size.y / 2;
        }
        else
        {
            //Stores the bottom position of the Y coordinate of the object where it's currently at
            targetY = transform.position.y - doorCollider.bounds.size.y / 2;
        }
    }
    //This method sets the boolean active from false to true
    public void startMove()
    {
        active = true;
    }

    //
    public void open()
    {
        active = true;
    }

    //
    public void close()
    {
        active = false;
    }
    // Update is called once per frame
    void Update()
    {
        //Checks if the boolean active is true
        if (active)
        {
            //Checks if the boolean Up is true
            if (Up)
            {
                //Checks if the Y position of the new location smaller is then the target Y position
                if (transform.position.y - doorCollider.bounds.size.y/2 <= targetY)
                {
                    //Moves the object up to the position till it reaches its target Y position
                    transform.position = new Vector3(transform.position.x, transform.position.y + Speed * Time.deltaTime, transform.position.z);
                }
            }
            else
            {
                //Checks if the Y position of the new location greater is then the target Y position
                if (transform.position.y + doorCollider.bounds.size.y/2 >= targetY)
                {
                    //Moves the object down to the position till it reaches its target Y position
                    transform.position = new Vector3(transform.position.x, transform.position.y + -Speed * Time.deltaTime, transform.position.z);
                }
            }
        }
    }
}
