using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class PopUpControl : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    [SerializeField] private TextMeshProUGUI Text;

    private void OnEnable()
    {
        GameManager.onStateChanged += StateChange;
    }

    public void StateChange(GameState State)
    {
        switch (State)
        {
            case GameState.BuildPlacement:
                Panel.SetActive(true);
                Text.transform.localScale = Vector3.zero;
                Text.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBounce);
                Text.text = "First of all place the build ";
                break;
            case GameState.Run:

                //Text.transform.localScale = Vector3.zero;
                Text.transform.DOScale(Vector3.zero, 0.5f).SetEase(Ease.OutBounce).OnComplete(() => Panel.SetActive(false));

                break;
            default:
                break;
        }
    }

}
