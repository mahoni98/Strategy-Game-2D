using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Product : MonoBehaviour
{

    [Header("Product")]
    public string Name;
    public int HealthValue;
    public int MaxCapacity;
    public string ProductInfo;
    public Sprite ProductImage;
    public bool CanProduce;

    public Type ProductType;
    public enum Type
    {
        Barracks,
        PowerPlant,
    }
    [Header("Units")]
    public List<ConCreteFactorySoldier> UnitUýPrefabs;
    //private Transform Content;

    public void CreateUnitBtn(Transform CreateUnitPos, Transform Content)
    {
        try
        {
            if (Content.childCount == 0)
            {
                for (int i = 0; i < UnitUýPrefabs.Count; i++)
                {
                    ConCreteFactorySoldier a = Instantiate(UnitUýPrefabs[i], Content);
                    a.BarrackPosition = CreateUnitPos;
                }
            }
            else
            { // update btn
                foreach (var item in Content.GetComponentsInChildren<ConCreteFactorySoldier>())
                {
                    item.BarrackPosition = CreateUnitPos;
                }
            }
        }
        catch (System.Exception ex)
        {

        }
    }
    //[Header("Units Base")]
    //public string UnitName;
    //public string UnitInfo;
    //public Sprite UnitProducedImage;

    //[Header("Units")]
    //public Button Soldie
}
