using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildFollow : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] private float OffsetX;
    [SerializeField] private float OffsetY;
    private void Update()
    {
        //transform. = 
        //transform.position = Target.localPosition/*new Vector3(Target.position.x + OffsetX, Target.position.y + OffsetY, 0)*/;
    }

}
