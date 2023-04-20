using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Manager.Singleton;
using DG.Tweening;
public class DragManager : SingletonManager<DragManager>
{
    public bool Entry = true;
    public Transform Build;
    public Transform CurrentGrid;
    public void SetPosition(Transform GridElement)
    {
        Build.DOMove(GridElement.position, 0.1f);
        //GridElement.GetComponent<GridElement>().ThereAreSomething = true;
    }

    public void ForTutorial()
    {
        //DOTween.KillAll();
        //CurrentDice.DOMove(Tutorial.Instance.GreenStart.transform.position, 0.2f).SetEase(Ease.Linear);
    }
}
