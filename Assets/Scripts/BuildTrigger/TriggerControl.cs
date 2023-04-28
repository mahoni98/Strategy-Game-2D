using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MyHelper;
using UnityEngine.EventSystems;
public class TriggerControl : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private bool Placed;
    [SerializeField] private DragColorControl _DragColorControl;
    [SerializeField] private bool _AnyTriggerBusyGrid = false; // does it have any contact with the full grid
    public List<GridElement> GridElements;
    private GridElement FalseGridELement;
    bool CanPlace = true;

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
    private void Update()
    {
        Debug.Log(CanPlace);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid.ThereAreSomething == false)
        {
            collision.GetComponent<Image>().color = Color.black;
            Grid.EnterBuild(transform.parent.name);
            h.GridElemetListControl(GridElements, Grid);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (CanPlace)
        {
            GridElement Grid = collision.GetComponent<GridElement>();
            if (Grid.ThereAreSomething == false || Grid.PlacedBuildName == transform.parent.name)
            {
                _DragColorControl.SetColor(DragColorControl.WhichColor.GreenOne);
                CanPlace = true;
            }
            else
            {
                _DragColorControl.SetColor(DragColorControl.WhichColor.RedOne);
                CanPlace = false;
                FalseGridELement = Grid;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid != null)
        {
            if (Placed == false)
            {
                if (Grid.ExitBuild(transform.parent.name))
                {
                    AnyTriggerBusyGrid = false;
                    collision.GetComponent<Image>().color = Color.gray;
                    h.GridElemetListControl(GridElements, Grid);
                }
            }
        }
        if (FalseGridELement == Grid)
            CanPlace = true;
    }
    public void MarkGrid()
    {
        foreach (var item in GridElements)
        {
            item.ThereAreSomething = true;
            item.PlacedBuildName = transform.parent.name;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (CanPlace)
        {
            Placed = true;
            MarkGrid();
            GetComponent<Collider2D>().enabled = false;
            _DragColorControl.SetColor(DragColorControl.WhichColor.Default);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<Collider2D>().enabled = true;
        Placed = false;
    }
}
