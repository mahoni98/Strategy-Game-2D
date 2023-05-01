using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class PopUpControl : SingletonManager<PopUpControl>
{
    [SerializeField] private GameObject Panel;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private string _PlaceFirst = "First of all place the build";
    public string PlaceFirst { get => _PlaceFirst; private set => _PlaceFirst = value; }

    private void OnEnable()
    {
        GameManager.onStateChanged += StateChange;
    }

    public void StateChange(GameState State)
    {
        switch (State)
        {
            case GameState.BuildPlacement:
                OpenPopUp(PlaceFirst);
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
        Text.text = Sentence;
    }
    public void ClosePopUp()
    {
        Panel.SetActive(false);
    }
    public bool StateControl()
    {
        if (GameManager.Instance.GameState == GameState.RunGame)
        {
            return true;
        }
        else
        {
            OpenPopUp(PlaceFirst);
            return false;
        }
    }
}
