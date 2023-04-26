using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class RunTimeScan : MonoBehaviour
{
    //public AILerp _AILerp;
    public AIDestinationSetter _AIDestinationSetter;
    public Transform Target;

    private void Start()
    {
        _AIDestinationSetter = FindObjectOfType<AIDestinationSetter>();
        //_AILerp.BrakeValue = 1f;
    }
    public void Deneme()
    {
        //_AILerp.reachedEndOfPath = true;
        var a = _AIDestinationSetter.target;
        if (a != null)
        {
            _AIDestinationSetter.target = null;
        }
        else
        {
            _AIDestinationSetter.target = Target;
        }
    }
}
