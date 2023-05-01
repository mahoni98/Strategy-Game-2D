using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSetPos : SingletonManager<BuildSetPos>
{
    public void SetPosition(Transform Build, Transform BuildParent, Transform GridElement, TriggerControl _TriggerControl, float OffsetX, float OffsetY)
    {
        if (DragManager.Instance.Entry)
        {
            BuildParent.DOMove(GridElement.position, 0.1f).OnComplete(() =>
            {
                Build.DOLocalMove(new Vector3(OffsetX, OffsetY, 0), 0.1f);
                GameManager.Instance.UpdateState(GameState.RunGame);
            });
        }
    }
}
