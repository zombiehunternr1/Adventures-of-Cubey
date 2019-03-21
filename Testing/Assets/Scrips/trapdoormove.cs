using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapdoormove : MonoBehaviour
{
    //Creating the game objects for panel 1, 2 and 3
    public GameObject panel;

    //Creating the game object for activate door
    public GameObject activateDoor;

    //Creating triggers with the information it gets from the script trapdoortrigger.cs
    private trapdoortrigger trigger;

    //Creating a private doormoving with the information it gets from the script movedoor.cs
    private MoveDoor doormoving;

    //create a private interger called state that is set to 0
    private int state = 0;


    // Start is called before the first frame update
    void Start()
    {
        //set the panels as triggers
        trigger = panel.GetComponent(typeof(trapdoortrigger)) as trapdoortrigger;
        //set the doormoving as activatedoor
        doormoving = activateDoor.GetComponent(typeof(MoveDoor)) as MoveDoor;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            //No panel is activated
            case 0:
                //checks if the player stept on the first trigger and sets the state to 1
                if (trigger.trigger == true)
                {
                    state = 1;
                }
                break;

            case 1:
                //when the triggers are triggered in the right order the door moves away
                doormoving.startMove();
                break;
        }
    }
}
