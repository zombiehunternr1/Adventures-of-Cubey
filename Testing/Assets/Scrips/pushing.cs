using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushing : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        //It gets its own rigidbody and add force to it and tell it to move away from to player
        this.GetComponent<Rigidbody>().AddForce(Vector3.forward);
    }
}
