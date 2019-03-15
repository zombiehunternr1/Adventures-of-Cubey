using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class multipressurehandler : ScriptableObject
{
    private int activeCount = 0;

    public int maxcount = 2;

    public bool both()
    {
        if(activeCount >= maxcount)
        {
            return true;
        }
        return false;
    }

    public void enter()
    {
        activeCount++;
    }

    public void exit()
    {
        activeCount--;
    }

    public void Reset()
    {
        activeCount = 0;
    }
}
