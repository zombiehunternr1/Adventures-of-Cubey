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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        
        if (controller.isGrounded)
        {
            Movedirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            Movedirection = transform.TransformDirection(Movedirection);
            Movedirection *= speed;
            if (Input.GetButton("Jump"))
                Movedirection.y = jumpSpeed;
            

        }
        Movedirection.y -= gravity * Time.deltaTime;
        controller.Move(Movedirection * Time.deltaTime);
        RaycastHit p1;

        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out p1, Mathf.Infinity);

        //rotate (I inverted the Axis (-5.0F) so that pressing left would actually send you left (or right for that matter))
        transform.Rotate(0, Input.GetAxis("Horizontal") * -5.0F, 0);
    }
}
