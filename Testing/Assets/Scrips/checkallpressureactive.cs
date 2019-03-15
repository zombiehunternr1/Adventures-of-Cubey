using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkallpressureactive : MonoBehaviour
{
    //Creating the game objects for panel 1, 2 and 3
    public GameObject panel1;
    public GameObject panel2;

    //Creating the game object for activate door
    public GameObject activateDoor;

    //Creating triggers with the information it gets from the script inputtrigger.cs
    private presureplatetrigger pressure1;
    private presureplatetrigger pressure2;

    //Creating a private doormoving with the information it gets from the script movedoor.cs
    private movedoor doormoving;

    // Start is called before the first frame update
    void Start()
    {
        //set the panels as triggers
        pressure1 = panel1.GetComponent(typeof(presureplatetrigger)) as presureplatetrigger;
        pressure2 = panel2.GetComponent(typeof(presureplatetrigger)) as presureplatetrigger;
        //set the doormoving as activatedoor
        doormoving = activateDoor.GetComponent(typeof(movedoor)) as movedoor;
    }

    private void OnTriggerEnter(Collider other)
    {
       
    }
}
