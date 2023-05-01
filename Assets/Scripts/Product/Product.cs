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

    [Header("Units")]
    public List<ConCreteFactorySoldier> UnitUýPrefabs;

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
}
