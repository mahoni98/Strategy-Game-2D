using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class PopUpControl : SingletonManager<PopUpControl>
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
                OpenPopUp("First of all place the build");
                break;
            case GameState.RunGame:
                ClosePopUp();
                break;
            default:
                break;
        }
    }
    public void OpenPopUp(string Sentence)
    {
        Panel.SetActive(true);
        Text.transform.localScale = Vector3.zero;
        Text.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBounce);
        Text.text = Sentence;
    }
    public void ClosePopUp()
    {
        Text.transform.DOScale(Vector3.zero, 0.5f).SetEase(Ease.OutBounce).OnComplete(() => Panel.SetActive(false));
    }
}
