using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpatternbuttons : MonoBehaviour
{
    //Creating the game objects for panel 1, 2 and 3
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    //Creating the game object for activate door
    public GameObject activateDoor;

    //Creating triggers with the information it gets from the script inputtrigger.cs
    private inputtrigger button1;
    private inputtrigger button2;
    private inputtrigger button3;

    //Creating a private doormoving with the information it gets from the script movedoor.cs
    private movedoor doormoving;

    //create a private interger called state that is set to 0
    private int state = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set the panels as triggers
        button1 = panel1.GetComponent(typeof(inputtrigger)) as inputtrigger;
        button2 = panel2.GetComponent(typeof(inputtrigger)) as inputtrigger;
        button3 = panel3.GetComponent(typeof(inputtrigger)) as inputtrigger;
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
                if (button1.trigger == true)
                {
                    state = 1;
                }
                break;

            case 1:
                //checks if the player stept on the second trigger and sets the state to 2
                if (button2.trigger == true)
                {
                    state = 2;
                }
                //checks if the player stept on the third trigger instead of the second one, if so it sets the state back to 0
                else if (button3.trigger == true)
                {
                    state = 0;
                }
                break;

            case 2:
                //checks if the player stept on the third trigger and sets the state to 3
                if (button3.trigger == true)
                {
                    state = 3;
                }
                //checks if the player stept on the first panel and sets the state back to 0
                else if (button1.trigger == true)
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
