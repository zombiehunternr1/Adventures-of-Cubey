using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class multipressurehandler : ScriptableObject
{
    private int activeCount = 0;

    public int maxcount = 2;

    public void Enter()
    {
        activeCount ++;
    }

    public void Exit()
    {
        activeCount --;
    }

    public void Reset()
    {
        activeCount = 0;
    }

    public bool Both()
    {
        if (activeCount >= maxcount)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
