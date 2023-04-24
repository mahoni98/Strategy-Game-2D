using UnityEngine;

public class ConCreteFactoryBarrack : Factory
{
    [SerializeField] private Barracks ProductPrefab;
    [SerializeField] private Transform Parent;
    public override IProduct GetProduct(Transform GridElement)
    {
        GameObject instance = Instantiate(ProductPrefab.gameObject, GridElement.localPosition, Quaternion.identity, Parent);
        Barracks newProduct = instance.GetComponent<Barracks>();
        instance.transform.localPosition = Vector3.zero;


        // each product contains its own logic

        // add any unique behavior to this factory
        return newProduct;

    }
}
