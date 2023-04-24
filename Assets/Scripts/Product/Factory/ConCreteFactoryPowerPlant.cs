using UnityEngine;

public class ConCreteFactoryPowerPlant : Factory
{
    [SerializeField] private PowerPlant ProductPrefab;
    [SerializeField] private Transform Parent;

    public override IProduct GetProduct(Transform GridElement)
    {
        GameObject instance = Instantiate(ProductPrefab.gameObject, GridElement.localPosition, Quaternion.identity, Parent);
        PowerPlant newProduct = instance.GetComponent<PowerPlant>();
        instance.transform.localPosition = Vector3.zero;
        // each product contains its own logic

        // add any unique behavior to this factory
        return newProduct;

    }
}
