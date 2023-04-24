using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour
{
    [SerializeField] private List<GameObject> Products;
    [SerializeField] private Transform ContentPanel;


    private void Start()
    {
        foreach (var item in Products)
        {
            Instantiate(item, ContentPanel);
        }
    }
}
