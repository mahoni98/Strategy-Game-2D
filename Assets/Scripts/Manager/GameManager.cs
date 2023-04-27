using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : SingletonManager<GameManager>
{
    public static event Action<GameState> onStateChanged;

    void Start()
    {
        UpdateState(GameState.Run);
    }
    public async void UpdateState(GameState state)
    {
        switch (state)
        {
            case GameState.BuildPlacement:
                break;
            case GameState.Run:
                break;
            default:
                break;
        }
        onStateChanged?.Invoke(state);
    }
}
public enum GameState
{
    BuildPlacement, Run
}


