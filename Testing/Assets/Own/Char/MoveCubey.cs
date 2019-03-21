using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubey : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotate = 3.0F;
    private Vector3 Movedirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        
        //don't allow any other input while player is in the air.
        if (controller.isGrounded)
        {
            //the main direction that the player is going to (facing to)
            Movedirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            //Changes the Axis acording to the point where the player faces towards
            Movedirection = transform.TransformDirection(Movedirection);
            //The movementspeed of the player
            Movedirection *= speed;
            //When pressed the corespoding button the string 'Jump' than..
            if (Input.GetButton("Jump"))
                //Axis Y is up/downward, matching this with a speed equals jump power
                Movedirection.y = jumpSpeed;
            

        }
        //drag the player back down like gravity pulls
        Movedirection.y -= gravity * Time.deltaTime;
        //execute alle the movement
        controller.Move(Movedirection * Time.deltaTime);

        // smooth rotate, so no more instant turning.
        transform.Rotate(0, Input.GetAxis("Horizontal") * 5.0F, 0);
    }
}
