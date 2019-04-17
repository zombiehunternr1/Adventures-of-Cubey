using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubey : MonoBehaviour
{
    public float movementSpeed = 10F;
    public float jump = 4F;
    private Rigidbody playerBody;



    private void Start()
    {
        playerBody = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 targetDirection = new Vector3(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
        

        //keep it steady while moving
        targetDirection.y = 0.0f;

        //moving
        transform.Translate(targetDirection, Space.World);


        

        if (targetDirection != new Vector3(0f, 0f, 0f))
        {
            transform.rotation = Quaternion.LookRotation(targetDirection);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
        }
    }
}