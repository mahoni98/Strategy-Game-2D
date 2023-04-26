using UnityEngine;

public class ConCreteFactorySoldier : Factory
{
    [SerializeField] private GameObject ProductPrefab;
    [SerializeField] private Transform Parent;
    private int ProductionCount = 1;

    public override IProduct GetProduct(Transform BarrackPosition)
    {
        GameObject instance = Instantiate(ProductPrefab.gameObject, BarrackPosition.localPosition, Quaternion.identity, Parent);
        Soldier1 newProduct = instance.transform.GetChild(0).GetComponent<Soldier1>();
        instance.name = ProductPrefab.name + ProductionCount.ToString();
        instance.transform.localPosition = BarrackPosition.localPosition;
        ProductionCount++;
        // each product contains its own logic

        // add any unique behavior to this factory
        return newProduct;

    }
}
