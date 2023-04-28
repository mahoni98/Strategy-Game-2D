using MyHelper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierTriggerControl : MonoBehaviour
{

    Helper h = new Helper();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid != null && Grid.ThereAreSomething == false)
        {
            Grid.EnterBuild(transform.parent.name);
            Grid.ThereAreSomething = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid != null)
        {
            if (Grid.ExitBuild(transform.parent.name))
            {
                collision.GetComponent<Image>().color = Color.gray;
            }
        }
    }

}
