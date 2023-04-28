using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MyHelper;
using UnityEngine.EventSystems;
public class TriggerControl : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private DragColorControl _DragColorControl;
    [SerializeField] public float OffsetX;
    [SerializeField] public float OffsetY;
    private Transform _BuildParent;
    private bool CanPlace = true;
    private bool Placed;
    public List<GridElement> GridElements;
    private GridElement FalseGridELement;
    Helper h = new Helper();
    public Transform BuildParent { get => _BuildParent; private set => _BuildParent = value; }


    private void Start()
    {
        _DragColorControl = GetComponent<DragColorControl>();
        BuildParent = transform.parent;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GridElement Grid = collision.GetComponent<GridElement>();
        if (Grid.ThereAreSomething == false)
        {
            collision.GetComponent<Image>().color = Color.black;
            Grid.EnterBuild(BuildParent.name);
            h.GridElemetListControl(GridElements, Grid);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (CanPlace)
        {
            GridElement Grid = collision.GetComponent<GridElement>();
            if (Grid.ThereAreSomething == false || Grid.PlacedBuildName == BuildParent.name)
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
                if (Grid.ExitBuild(BuildParent.name))
                {
                    //AnyTriggerBusyGrid = false;
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
            item.PlacedBuildName = BuildParent.name;
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
            DragManager.Instance.Entry = false;
            DragManager.Instance.Build = null;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<Collider2D>().enabled = true;
        Placed = false;
    }
    private void OnDestroy()
    {
        foreach (var item in GridElements)
        {
            item.ThereAreSomething = false;
            item.PlacedBuildName = "";
            item.GetComponent<Image>().color = Color.gray;
        }
    }
}
