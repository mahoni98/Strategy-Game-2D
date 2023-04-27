using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToCreateUnit : MonoBehaviour
{
    //public Transform BornTransform;
    public ConCreteFactoryBarrack _ConCreteFactoryBarrack;
    public ConCreteFactoryPowerPlant _ConCreteFactoryPowerPlant;
    public ConCreteFactorySoldier _ConCreteFactorySoldier;

    public void GetProductAtClick(Product.Type Type, Transform CreatePosition)
    {
        switch (Type)
        {
            case Product.Type.Barracks:
                _ConCreteFactorySoldier.GetProduct(CreatePosition); // creating barracks product. so Soldier 
                break;
            case Product.Type.PowerPlant:
                break;
        }
    }
}
