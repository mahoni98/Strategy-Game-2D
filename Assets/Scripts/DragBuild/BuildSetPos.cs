using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSetPos : SingletonManager<BuildSetPos>
{
    public void SetPosition(Transform Build, Transform BuildParent, Transform GridElement, TriggerControl _TriggerControl, float OffsetX, float OffsetY)
    {
        Build.parent = null;
        BuildParent.DOMove(GridElement.position, 0.1f).OnComplete(() =>
        {
            Build.parent = BuildParent;
            Build.DOLocalMove(new Vector3(OffsetX, OffsetY, 0), 0.1f);
            _TriggerControl.MarkGrid();
            GameManager.Instance.UpdateState(GameState.RunGame);
            AstarPath.active.Scan();

        });
    }
}
