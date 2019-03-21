using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerCheckerOrdered : ITriggerChecker
{
    //Create listobjects named triggers and triggered
    List<GameObject> triggers = new List<GameObject>();
    List<GameObject> triggered = new List<GameObject>();

    public TriggerCheckerOrdered(List<GameObject> triggers)
    {
        this.triggers = triggers;
    }

    //Created a boolean called checkTrigger that contains the gameobject trigger
    public bool checkTrigger(GameObject trigger)
    {
        //checks if the triggers list contains the trigger and if the triggered list doesn't contain the trigger.
        //So I check if the trigger isn't already been triggered
        if (triggers.Contains(trigger) && !triggered.Contains(trigger))
        {
            //Add the trigger to the triggered list
            triggered.Add(trigger);
        }
        //Return the function eveluateTriggerState
        return evaluateTriggerState();
    }

    //Created a boolean called checkUntrigger that contains the gameobject trigger
    /// <summary>
    /// Untriggers input trigger if it was previously triggered.
    /// </summary>
    /// <param name="trigger">The GameObject that triggered the IActivatable</param>
    /// <returns>Are all triggers currently triggered</returns>
    public bool checkUntrigger(GameObject trigger)
    {
        //Checks if the list triggered contains trigger
        if (triggered.Contains(trigger))
        {
            //Removes the trigger from the triggered list
            triggered.Clear();
        }
        //Retruns the function eveluateTriggerState
        return !evaluateTriggerState();
    }

    //Created a private boolean called evaluateTriggerState
    private bool evaluateTriggerState()
    {
        bool t = true;
        if (triggers.Count != triggered.Count)
        {
            t = false;
        }
        else
        {
            for (int i = 0; i < triggers.Count; i++)
            {
                if (triggered[i] != triggers[i])
                {
                    t = false;
                    break;
                }
            }
        }
        if (!t && triggers.Count==triggered.Count)
        {
            triggered.Clear();
        }
        //Returns a check if the triggered count is equal to the triggers count
        return t;
    }
}
