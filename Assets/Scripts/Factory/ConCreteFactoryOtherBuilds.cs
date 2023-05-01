using UnityEngine;

public class ConCreteFactoryOtherBuilds : Factory
{
    [SerializeField] private OtherBuild ProductPrefab;
    [SerializeField] private Transform Parent;
    private int ProductionCount = 1;

    public override IProduct GetProduct(Transform GridElement)
    {
        GameObject instance = Instantiate(ProductPrefab.gameObject, GridElement.localPosition, Quaternion.identity, Parent);
        OtherBuild newProduct = instance.GetComponent<OtherBuild>();
        instance.transform.localPosition = Vector3.zero;
        instance.name = ProductPrefab.name + ProductionCount.ToString();
        ProductionCount++;
        return newProduct;
    }
}
