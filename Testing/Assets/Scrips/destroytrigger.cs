using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroytrigger : MonoBehaviour
{
    //Created a boolean called collided
    bool collided;

    IEnumerator OnTriggerEnter(Collider collider)
    {
        //Set the boolean to true
        collided = true;
        //Waits executing the rest of the code for 2 seconds
        yield return new WaitForSeconds(2);
        //Checks if collided is true
        if (collided)
        {
            //selfdestructs object
            Destroy(gameObject);
        }
    }
}
