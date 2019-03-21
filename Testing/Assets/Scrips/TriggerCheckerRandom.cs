using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class TriggerCheckerRandom : ITriggerChecker
{
    //Create listobjects named triggers and triggered
    List<GameObject> triggers = new List<GameObject>();
    List<GameObject> triggered = new List<GameObject>();

    //Constuctor for creating the triggers list when the class has been called
    public TriggerCheckerRandom(List<GameObject> triggers)
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
        //Checkjs if the list triggered contains trigger
        if (triggered.Contains(trigger))
        {
            //Removes the trigger from the triggered list
            triggered.Remove(trigger);
        }
        //Retruns the function eveluateTriggerState
        return !evaluateTriggerState();
    }

    //Created a private boolean called evaluateTriggerState
    private bool evaluateTriggerState()
    {
        //Returns a check if the triggered count is equal to the triggers count
        return triggered.Count == triggers.Count;
    }
}
