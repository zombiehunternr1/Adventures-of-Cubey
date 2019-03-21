using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActivatable
{
    void Trigger(GameObject trigger);
    void Untrigger(GameObject trigger);
}
