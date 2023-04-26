using UnityEngine;
using UnityEngine.UI;

public class Product : MonoBehaviour
{
    [Header("Product")]
    public string Name;
    public int HealthValue;
    public int MaxCapacity;
    public string ProductInfo;
    public Sprite ProductImage;
    public bool CanProduce;
    //public Transform Position;
    public Type ProductType;
    public enum Type
    {
        Barracks, 
        PowerPlant,

    }

    [Header("Unit Produced")]
    public string UnitName;
    public string UnitInfo;
    public Sprite UnitProducedImage;
}
