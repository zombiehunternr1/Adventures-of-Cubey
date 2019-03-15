using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    public float speed;

    private Rigidbody playerBody;
    private Vector3 inputVector;

    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal") * 10f, playerBody.velocity.y, Input.GetAxis("Vertical") * 10f);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
    }
    void FixedUpdate ()
    {
        playerBody.velocity = inputVector;
    }
}
