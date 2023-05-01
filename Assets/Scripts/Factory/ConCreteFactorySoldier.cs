using UnityEngine;
using UnityEngine.UI;

public class ConCreteFactorySoldier : Factory
{
    [SerializeField] private GameObject ProductPrefab;
    private Transform Parent;
    private Transform _BarrackPosition;


    private int ProductionCount = 1;

    public Transform BarrackPosition { get => _BarrackPosition; set => _BarrackPosition = value; }

    private void Start()
    {
        Parent = FindObjectOfType<Canvas>().transform;
        GetComponent<Button>().onClick.AddListener(() => GetProduct(BarrackPosition));
    }

    public override IProduct GetProduct(Transform BarrackPosition)
    {
        if (PopUpControl.Instance.StateControl() == false) return null;
        GameObject instance = Instantiate(ProductPrefab.gameObject, BarrackPosition.localPosition, Quaternion.identity, Parent);
        Soldier1 newProduct = instance.transform.GetChild(0).GetComponent<Soldier1>();
        instance.name = ProductPrefab.name + ProductionCount.ToString();
        instance.transform.localPosition = BarrackPosition.localPosition;
        ProductionCount++;
        return newProduct;
    }
}
