using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorActivate : MonoBehaviour, IActivatable
{
    private MoveDoor doorMover;
    private ITriggerChecker triggerChecker;
    public TriggerTypes triggerType;

    public List<GameObject> triggers;

    public void Trigger(GameObject trigger)
    {
        if (!triggerChecker.checkTrigger(trigger)) return;
        doorMover.open();

    }

    public void Untrigger(GameObject trigger)
    {
        if (triggerChecker.checkUntrigger(trigger)) return;
        doorMover.close();
    }

    void Start()
    {
        doorMover=gameObject.GetComponent<MoveDoor>();
        switch (triggerType)
        {
            case TriggerTypes.ORDERED:
                triggerChecker = new TriggerCheckerOrdered(triggers);
                break;
            case TriggerTypes.RANDOM:
                triggerChecker = new TriggerCheckerRandom(triggers);
                break;
        }

    }
}
