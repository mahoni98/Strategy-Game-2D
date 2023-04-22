using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class GridElement : MonoBehaviour
{
    [SerializeField] private bool _ThereAreSomething = false;
    [SerializeField] private string _PlacedBuildName;

    public bool ThereAreSomething { get => _ThereAreSomething; set => _ThereAreSomething = value; }
    public string PlacedBuildName { get => _PlacedBuildName; set => _PlacedBuildName = value; }

    public bool ExitBuild(string Name)
    {
        if (_PlacedBuildName == Name)
        {
            WhenGridAction("");
            ThereAreSomething = false;
            return true;
        }
        return false;
    }
    public void EnterBuild(string Name)
    {
        WhenGridAction( Name);
    }
    public void WhenGridAction(string Name)
    {
        _PlacedBuildName = Name;
    }
}
