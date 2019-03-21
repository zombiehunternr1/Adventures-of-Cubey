using UnityEngine;
using System.Collections;

public interface ITriggerChecker
{
    bool checkTrigger(GameObject trigger);
    bool checkUntrigger(GameObject trigger);
}
