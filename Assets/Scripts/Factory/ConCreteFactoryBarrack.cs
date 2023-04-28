using UnityEngine;

public class ConCreteFactoryBarrack : Factory
{
    [SerializeField] private Barracks ProductPrefab;
    [SerializeField] private Transform Parent;
    private int ProductionCount = 1;
    public override IProduct GetProduct(Transform GridElement)
    {
        GameObject instance = Instantiate(ProductPrefab.gameObject, GridElement.localPosition, Quaternion.identity, Parent);
        Barracks newProduct = instance.GetComponent<Barracks>();
        instance.transform.localPosition = Vector3.zero;
        instance.name = ProductPrefab.name + ProductionCount.ToString();
        ProductionCount++;
        return newProduct;
    }
}
