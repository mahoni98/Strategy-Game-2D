using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : SingletonManager<GameManager>
{
    public static event Action<GameState> onStateChanged;
    public GameState GameState;
    void Start()
    {
        UpdateState(GameState.RunGame);
    }
    public async void UpdateState(GameState state)
    {

        if (state != GameState)
        {
            GameState = state;
            onStateChanged?.Invoke(state);
        }
    }
}
public enum GameState
{
    BuildPlacement, RunGame, ThereIsSomeAttack
}


