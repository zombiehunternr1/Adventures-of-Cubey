using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpatternpressure : MonoBehaviour
{
    //Creating the game objects for panel 1, 2 and 3
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    //Creating the game object for activate door
    public GameObject activateDoor;

    //Creating triggers with the information it gets from the script inputtrigger.cs
    private presureplatetrigger pressure1;
    private presureplatetrigger pressure2;
    private presureplatetrigger pressure3;

    //Creating a private doormoving with the information it gets from the script movedoor.cs
    private movedoor doormoving;

    //create a private interger called state that is set to 0
    private int state = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set the panels as triggers
        pressure1 = panel1.GetComponent(typeof(presureplatetrigger)) as presureplatetrigger;
        pressure2 = panel2.GetComponent(typeof(presureplatetrigger)) as presureplatetrigger;
        pressure3 = panel3.GetComponent(typeof(presureplatetrigger)) as presureplatetrigger;
        //set the doormoving as activatedoor
        doormoving = activateDoor.GetComponent(typeof(movedoor)) as movedoor;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            //No panel is activated
            case 0:
                //checks if the player stept on the first trigger and sets the state to 1
                if (pressure1.trigger == true)
                {
                    state = 1;
                }
                break;

            case 1:
                //checks if the player stept on the second trigger and sets the state to 2
                if (pressure2.trigger == true)
                {
                    state = 2;
                }
                //checks if the player stept on the third trigger instead of the second one, if so it sets the state back to 0
                else if (pressure3.trigger == true)
                {
                    state = 0;
                }
                break;

            case 2:
                //checks if the player stept on the third trigger and sets the state to 3
                if (pressure3.trigger == true)
                {
                    state = 3;
                }
                //checks if the player stept on the first panel and sets the state back to 0
                else if (pressure1.trigger == true)
                {
                    state = 0;
                }
                break;

            case 3:
                //when the triggers are triggered in the right order the door moves away
                doormoving.startMove();
                break;

            default:

                break;
        }
    }
}
