using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MyHelper;
public class TriggerControl : MonoBehaviour
{
    [SerializeField] private DragColorControl _DragColorControl;

    [SerializeField] private bool _AnyTriggerBusyGrid = false; // does it have any contact with the full grid
    public List<GridElement> GridElements;
    Helper h = new Helper();
    public bool AnyTriggerBusyGrid
    {
        get { return _AnyTriggerBusyGrid; }
        set { _AnyTriggerBusyGrid = value; }
    }
    private void Start()
    {
        if (transform.parent.GetComponent<DragColorControl>() != null)
        {
            _DragColorControl = transform.parent.GetComponent<DragColorControl>();
        }
        else
        {
            _DragColorControl = GetComponent<DragColorControl>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid != null && Grid.ThereAreSomething == false )
        {
            collision.GetComponent<Image>().color = Color.black;
            Grid.EnterBuild(transform.parent.name);
            h.GridElemetListControl(GridElements, Grid);
        }
        else
        {
            //_DragColorControl.SetColor(DragColorControl.WhichColor.RedOne);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid != null)
        {
            if (Grid.ExitBuild(transform.parent.name))
            {
                AnyTriggerBusyGrid = false;
                collision.GetComponent<Image>().color = Color.gray;
                h.GridElemetListControl(GridElements, Grid);
            }
        }
    }
    public void MarkGrid()
    {
        foreach (var item in GridElements)
        {
            item.ThereAreSomething = true;
            item.PlacedBuildName = transform.parent.name;
        }
    }
}
