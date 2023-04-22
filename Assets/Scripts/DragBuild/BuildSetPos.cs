using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSetPos : SingletonManager<BuildSetPos>
{
    public void SetPosition(Transform Parent,Transform GridElement, TriggerControl _TriggerControl, float OffsetX, float OffsetY)
    {
        transform.parent = null;
        Parent.DOMove(GridElement.position, 0.1f).OnComplete(() =>
        {
            transform.parent = Parent;
            transform.DOLocalMove(new Vector3(-48f, 48f, 0), 0.1f);
            //transform.localPosition = ;
            _TriggerControl.MarkGrid();
        });
    }
}
